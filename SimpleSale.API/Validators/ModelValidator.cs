using FluentValidation;
using FluentValidation.Results;
using System.Reflection;

namespace SimpleSale.API.Validators
{
    public class ModelValidator
    {
        public static ValidationResult Validate<T>(T model)
        {
            if (model == null) throw new ArgumentNullException("Null model");

            var validatorType = FindValidatorType(Assembly.GetExecutingAssembly(), typeof(AbstractValidator<T>));

            if (validatorType == null)
            {
                throw new Exception($@"Cannot find validator type for  {typeof(T)}");
            }

            var validatorInstance = (IValidator)Activator.CreateInstance(validatorType)!;

            return validatorInstance.Validate(new ValidationContext<T>(model));
        }

        private static Type FindValidatorType(Assembly assembly, Type evt)
        {
            if (assembly == null) throw new ArgumentNullException("assembly");
            if (evt == null) throw new ArgumentNullException("evt");
            return assembly.GetTypes().FirstOrDefault(t => t.IsSubclassOf(evt));
        }
    }
}
