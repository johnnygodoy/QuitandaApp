using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quitanda.CrossCutting.Helper
{
    public static  class EncryptHelper
    {
        public static string EncryptPassword(this string senha)
        {
            var data = Encoding.ASCII.GetBytes(senha);
            data = new SHA256Managed().ComputeHash(data);

            return Convert.ToBase64String(data);
        }
    }
}
