using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOEN_ERP.Utilities
{
    public class AuthenSSO
    {
        public static string DecodingFromBase64(string value)
        {
            byte[] data = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(data);
        }

        public static string EncodingToBase64(string value)
        {
            byte[] data = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(data);
        }

    }
}
