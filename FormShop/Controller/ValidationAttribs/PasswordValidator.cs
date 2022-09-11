using System.ComponentModel.DataAnnotations;

namespace FormShop.Controller.ValidationAttribs
{
    class PasswordValidator : ValidationAttribute 
    {
        public bool IsValid(string password)
        {
            if (!password.Any(char.IsUpper)) return false;
            if(!password.Any(char.IsDigit)) return false;
            if (!password.Any(char.IsPunctuation)) return false;

            

            return true;
        }
    }
}