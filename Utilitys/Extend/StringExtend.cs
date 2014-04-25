using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitys.Extend
{
    public static class StringExtend
    {
        public static string L(this string str)
        {
            //get value from cookie
           string type= Utility.GetCookie("language_type");
           //从
            return "";
        }

        public static bool IsNullOrEmtype(this string str)
        {
           return string.IsNullOrWhiteSpace(str);
        }
    }
}
