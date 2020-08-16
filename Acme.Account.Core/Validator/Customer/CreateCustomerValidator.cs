using Acme.Account.Core.Command.Customer;
using FluentValidation;

namespace Acme.Account.Core.Validator.Customer
{
    public class CreateCustomerValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerValidator()
        {
            RuleFor(x => x.FirstName).NotNull().NotEmpty().WithMessage("First name can not be empty");
            RuleFor(x => x.LastName).NotNull().NotEmpty().WithMessage("Last name can not be empty");
            RuleFor(x => x.Email).NotNull().NotEmpty().WithMessage("Email can not be empty");
            RuleFor(x => x.Mobile).NotNull().NotEmpty().WithMessage("Mobile can not be empty");
            RuleForEach(x => x.Addresses).SetValidator(new AddressValidator());
            //RuleFor(x => x.Addresses).Must(x => x.Addresses.Count > 0);
        }
    }
}
