using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormat
{
    public class Customer
    {
        private readonly int CONTACT_PHONE_LENGTH = 11;
        private string contactPhone;

        public string Name { get; set; }

        public decimal Revenue { get; set; }


        public string ContactPhone
        {
            get { return contactPhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                value = PhoneCorrector(value);

                if (value.Length != CONTACT_PHONE_LENGTH)
                {
                    throw new ArgumentException("Phone number must be in format # ### ### ####");
                }

                contactPhone = string.Format("{0:+# (###) ###-####}", Convert.ToInt64(value));
            }
        }

        public Customer(string name, decimal revenue, string phone)
        {
            Name = name;
            Revenue = revenue;
            ContactPhone = phone;
        }

        public override string ToString()
        {
            return ToString("pnr", null);
        }

        public string ToString(string format)
        {
            return ToString("pnr", null);
        }

        public string ToString(IFormatProvider provider)
        {
            return ToString("pnr", provider);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            if (format == null)
                throw new ArgumentNullException();

            return string.Format(format, (CustomerFormat)provider, this);
        }

        private string PhoneCorrector(string str)
        {
            StringBuilder temp = new StringBuilder();
            foreach (char s in str)
            {
                if (char.IsDigit(s))
                {
                    temp.Append(s);
                }
            }
            return temp.ToString();
        }

    }
}
