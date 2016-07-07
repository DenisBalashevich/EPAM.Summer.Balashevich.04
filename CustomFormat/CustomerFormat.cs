using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormat
{
    public class CustomerFormat : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type typeName)
        {
            if (typeName == typeof(ICustomFormatter))
                return this;
            return null;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null || IsFormat(format) == false)
                throw new ArgumentNullException();

            if (arg == null)
                throw new ArgumentNullException();

            if (arg is Customer == false)
                throw new ArgumentException();

            Customer customer = (Customer)arg;
            format = format.ToUpper();
            var result = new StringBuilder();

            if (format.Contains("N"))
                result.Append(customer.Name.ToString() + " ,");

            if (format.Contains("P"))
                result.Append(customer.ContactPhone.ToString() + " ,");

            if (format.Contains("R"))
                result.Append(customer.Revenue.ToString() + " ,");

            return result.ToString().Remove(result.Length - 1);
        }
        private bool IsFormat(string str)
        {
            str = str.ToUpper();
            foreach (var a in str)
            {
                if (str.Contains("N") || str.Contains("R") || str.Contains("P"))
                    return true;
            }
            return false;
        }

    }
}
