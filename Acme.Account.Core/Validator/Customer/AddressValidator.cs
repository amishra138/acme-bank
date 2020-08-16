using Acme.Account.Core.Command.Customer;
using FluentValidation;

namespace Acme.Account.Core.Validator.Customer
{
    internal class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Type).IsInEnum().WithMessage("Address type can not be empty");
            RuleFor(x => x.Address1).NotEmpty().WithMessage("Address1 can not be empty");
            RuleFor(x => x.State).NotEmpty().WithMessage("State can not be empty");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country can not be empty");
            RuleFor(x => x.Pincode).NotEmpty().WithMessage("Pincode can not be empty");
        }
    }
}
