using System.Security.Cryptography;

namespace FormShop.Controller
{
    public static class HashController
    {
        public static string GenerateHash(string data)
        {
            MD5 mD5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(data);
            byte[] hashBytes = mD5.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes).ToLower();
        }
    }
}
