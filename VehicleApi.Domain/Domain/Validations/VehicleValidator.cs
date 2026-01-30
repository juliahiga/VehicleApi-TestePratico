using FluentValidation;
using VehicleApi.Domain.Entities;

namespace VehicleApi.Domain.Validations
{
    public class VehicleValidator : AbstractValidator<Vehicle>
    {
        public VehicleValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.Brand)
                .IsInEnum();

            RuleFor(x => x.Model)
                .NotEmpty()
                .MaximumLength(30);
        }
    }
}
