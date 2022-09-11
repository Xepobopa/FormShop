using FormShop.Controller.ValidationAttribs;

namespace FormShop.Controller
{
    public class PasswordController
    {
        private PasswordController()
        {
            maxPasswordLength = 8;
        }

        public PasswordController(uint maxPasswordLength = 12)
        {
            this.maxPasswordLength = maxPasswordLength;
        }

        public bool IsValid(string password)
        {
            if (password.Length < maxPasswordLength) return false;
            if (!new PasswordValidator().IsValid(password)) return false;

            return true;
        }

        public uint maxPasswordLength { get; private set; }
        
    }

    

}
