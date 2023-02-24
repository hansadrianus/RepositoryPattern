using Application.Interfaces.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class AuthController : ApplicationBaseController
    {
        private readonly IRepositoryWrapper _repository;

        public AuthController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> UsersAsync()
        {


            return View();
        }
    }
}
