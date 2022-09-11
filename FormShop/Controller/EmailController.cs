using FormShop.Controller.ValidationAttribs;

namespace FormShop.Controller
{
    public class EmailController
    {

        public bool IsValid(string email)
        {
            return new EmailValidator().IsValid(email);
        }

    }
}
