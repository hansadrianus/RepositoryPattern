using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Entities;
using Application.Interfaces.Persistence;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces.Wrappers;

namespace WebMVC.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser<string>> _userManager;
        private readonly SignInManager<ApplicationUser<string>> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IApplicationContext _context;
        private readonly IRepositoryWrapper _repository;

        public LoginModel(SignInManager<ApplicationUser<string>> signInManager,
            ILogger<LoginModel> logger,
            UserManager<ApplicationUser<string>> userManager,
            IApplicationContext context,
            IRepositoryWrapper repository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
            _repository = repository;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public int LCID { get; set; }

        public SelectList LanguageCultureSelectList { get; set; }

        public class InputModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null, string lcid = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            await SetLanguageAsync(lcid);

            LanguageCultureSelectList = new SelectList(await PrepareLanguageCultureAsync(), "LCID", "Description", LCID);
            HttpContext.Session.SetInt32("CultureInfoSession", LCID);
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null, string lcid = null)
        {
            returnUrl ??= Url.Content("~/");
            await SetLanguageAsync(lcid);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(Input.Username);
                var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded && user.RowStatus == 0)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor && user.RowStatus == 0)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut && user.RowStatus == 0)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    LanguageCultureSelectList = new SelectList(await PrepareLanguageCultureAsync(), "LCID", "Description", LCID);
                    HttpContext.Session.SetInt32("CultureInfoSession", LCID);
                    return Page();
                }
            }

            return Page();
        }

        private async Task<IEnumerable<LanguageCulture<int>>> PrepareLanguageCultureAsync() => await _repository.LanguageCulture.GetAllAsync();

        private async Task SetLanguageAsync(string lcid)
        {
            if (string.IsNullOrEmpty(lcid))
            {
                LanguageCulture<int> language = await _repository.LanguageCulture.GetAsync(q => q.IsDefaultLanguage == true);
                LCID = (language is null) ? 1033 : language.LCID;
                CultureInfo.CurrentCulture = new CultureInfo(LCID);
                CultureInfo.CurrentUICulture = new CultureInfo(LCID);
            }
            else
            {
                LCID = Convert.ToInt32(lcid);
                CultureInfo.CurrentCulture = new CultureInfo(LCID);
                CultureInfo.CurrentUICulture = new CultureInfo(LCID);
            }
        }
    }
}
