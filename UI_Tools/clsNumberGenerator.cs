using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreProject.UI_Tools
{
    public class clsNumberGenerator
    {
        private static Random _random = new Random();
        public static string GenerateRandomTrackingNumber()
        {
            int length = _random.Next(12, 21);
            return GenerateAlphanumeric(length);
        }

        // Helper: Generate alphanumeric string (A-Z, 0-9)
        private static string GenerateAlphanumeric(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
                sb.Append(chars[_random.Next(chars.Length)]);

            return sb.ToString();
        }

        // Helper: Generate numeric string only
        public static string GenerateNumeric(int length)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
                sb.Append(_random.Next(0, 10));

            return sb.ToString();
        }
    }
}
