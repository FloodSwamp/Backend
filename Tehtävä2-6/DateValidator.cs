namespace Tehtava2
{
    public class DateValidator: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext){
            DateTime time = (DateTime)value;

            if (time < System.DateTime.Now) {
                return ValidationResult.Success;
            } 
                return new ValidationResult("Date error");
            }
        }
    }