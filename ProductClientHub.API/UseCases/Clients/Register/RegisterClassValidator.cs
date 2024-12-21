using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClassValidator : AbstractValidator<RequestClientJson>
    {
        public RegisterClassValidator()
        {
            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
            RuleFor(client => client.Email).EmailAddress().WithMessage("O E-mail não é valido.");
        }
    }
}
