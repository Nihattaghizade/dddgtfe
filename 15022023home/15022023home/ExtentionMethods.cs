using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _15022023home
{
    internal static class ExtentionMethods
    {

        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();

            return newStr;
        }

        public static bool ContainsOnlyLetter(this string str)
        {
            if (str == null) return false;

            foreach (var cr in str)
            {
                if (!char.IsLetter(cr))
                    return false;
            }
            return true;
        }

        public static bool IsOdd(this string str)
        {
            if (str % 2 == 0) return true;

            foreach (var n in str)
            {
                if(n % 2 == 1) 
                    return false;
            }
            return true;
        }

        public static bool IsEven(this string str)
        {
            if (str % 2 == 1) return true;

            foreach (var n in str)
            {
                if (n % 2 == 0)
                    return false;
            }
            return true;
        }

        public static string GetValueIndexes(this string str)
        {

        }

    }
}
