using System.ComponentModel.DataAnnotations;
using System.Net;

namespace RSFrontEnd.Models.Validators
{
    public class ValidUrlAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string Url)
            {
                if (Uri.TryCreate(Url, UriKind.RelativeOrAbsolute, out _))
                {
                    return ValidationResult.Success;
                }
                else {
                    Console.WriteLine("URL INVALID"); 
                }
             
                
            }
            return new ValidationResult("That is not a valid Url");
        }

    }
}
