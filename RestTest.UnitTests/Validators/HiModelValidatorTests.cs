using FluentValidation.TestHelper;
using WebApi.Models;
using WebApi.Validators;
using Xunit;

namespace RestTest.UnitTests.Validators
{
    public class HiModelValidatorTests
    {
        public HiModelValidatorTests()
        {
            Validator = new HiModelValidator();
        }

        public HiModelValidator Validator { get; set; }

        [Fact]
        public void Negative_Id_Returns_Error()
        {
            HiModel model = new HiModel {Id = -1, Name = "Ok"};
            TestValidationResult<HiModel> result = Validator.TestValidate(model);
            result.ShouldHaveValidationErrorFor(mode => mode.Id);
        }

        [Fact]
        public void Positive_Id_Returns_OK()
        {
            HiModel model = new HiModel {Id = 1, Name = "Ok"};
            TestValidationResult<HiModel> result = Validator.TestValidate(model);
            result.ShouldNotHaveValidationErrorFor(mod => mod.Id);
        }
    }
}