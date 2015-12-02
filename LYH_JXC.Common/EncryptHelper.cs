using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LYH_JXC.Common
{
    public class EncryptHelper
    {

        /// <summary>
        /// md5加密
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string message)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = Encoding.Default.GetBytes(message);
            byte[] outStr = md5.ComputeHash(result);
            string md5string = BitConverter.ToString(outStr).Replace("-", "");
            return md5string;
        }

    }
}
