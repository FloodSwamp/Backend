using System.ComponentModel.DataAnnotations;

namespace Tehtävä2
{
    public class TypeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string ItemType = value as string;
            
            if (ItemType == "shield") 
            {
                return ValidationResult.Success;
            }
            else if (ItemType == "knife") 
            {
                return ValidationResult.Success;
            }
            else if (ItemType == "spoon") 
            {
                return ValidationResult.Success;
            } else 
            {
                return new ValidationResult("Item type error");
            }
        }
    }
}