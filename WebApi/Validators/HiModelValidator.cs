using FluentValidation;
using WebApi.Models;

namespace WebApi.Validators
{
    public class HiModelValidator : AbstractValidator<HiModel>
    {
        public HiModelValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Name).NotEmpty();
        }   
    }
}
