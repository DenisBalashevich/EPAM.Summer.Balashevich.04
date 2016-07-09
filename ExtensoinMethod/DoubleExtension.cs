using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensoinMethod
{
    public static class DoubleExtension
    {
        private static int bits = 8;
        public static string ToIEEE754(this double x)
        {
            StringBuilder result = new StringBuilder();
            byte[] bytes = BitConverter.GetBytes(x);

            foreach (var a in bytes)
            {
                result.Insert(0, ToBinary(a));
            }
            return result.ToString();
        }

        private static string ToBinary(int x)
        {
            int lenght = Convert.ToString(x, 2).Length;
            string result = Convert.ToString(x, 2);

            if (lenght < bits)
                for (int i = lenght; i < bits; i++)
                    result = result.Insert(0, "0");
            return result;
        }
    }
}
