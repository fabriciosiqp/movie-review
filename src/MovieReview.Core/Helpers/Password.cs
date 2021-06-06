using System.Security.Cryptography;
using System.Text;

namespace MovieReview.Core.Helpers
{
    public class Password
    {
        private readonly HashAlgorithm _hashAlgorithm;

        public Password()
        {
            _hashAlgorithm = SHA512.Create();
        }

        public string GenerateHash(string password)
        {

            var encodedValue = Encoding.UTF8.GetBytes(password);
            var encryptedPassword = _hashAlgorithm.ComputeHash(encodedValue);
            var sb = new StringBuilder();
            foreach (var character in encryptedPassword)
            {
                sb.Append(character.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
