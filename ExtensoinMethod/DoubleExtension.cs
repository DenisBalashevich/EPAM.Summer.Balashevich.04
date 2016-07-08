using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensoinMethod
{
    public static class DoubleExtension
    {
        public static string ToIEEE754(this double x)
        {
            StringBuilder result = new StringBuilder();
            byte[] bytes = BitConverter.GetBytes(x);

            foreach (var a in bytes)
            {
                result.Append(ToBinary(a));
            }
            return Reverse(result.ToString());
        }

        private static string ToBinary(int x)
        {
            string result = Convert.ToString(x, 2);
            int lenght = result.Length;
           
            if (lenght < 8)
                for (int i = lenght; i < 8; i++)
                    result += '0';
            return result;
        }

        private static string Reverse(string str)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                temp.Append(str[i]);
            }
            return temp.ToString();
        }
    }
}
