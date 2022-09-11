using System.ComponentModel.DataAnnotations;

// __@__.__

namespace FormShop.Controller.ValidationAttribs
{
    public class EmailValidator : ValidationAttribute
    {
        public bool IsValid(string email)
        {
            if(email.Count(x => x == '@') != 1) return false;
            if (email.Count(x => x == '.') != 1) return false;

            string[] separated_by_email_sign_strings = email.Split('@');
            string[] separated_by_dot = separated_by_email_sign_strings[1].Split('.');

            if (separated_by_email_sign_strings[0].Length == 0) return false;
            if (separated_by_dot[0].Length == 0) return false;
            if (separated_by_dot[1].Length == 0) return false;

            if (!separated_by_email_sign_strings[0].All(char.IsLetterOrDigit)) return false;
            if (!separated_by_dot[0].All(char.IsLetterOrDigit)) return false;
            if (!separated_by_dot[1].All(char.IsLetterOrDigit)) return false;

            return true;
        }

    }
}
