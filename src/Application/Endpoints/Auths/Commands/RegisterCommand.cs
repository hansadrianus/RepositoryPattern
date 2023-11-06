using Application.Models;
using Application.ViewModels;
using MediatR;

namespace Application.Endpoints.Auths.Commands
{
    public class RegisterCommand : IRequest<EndpointResult<RegisterViewModel>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string PhoneNumber { get; set; }
    }
}
