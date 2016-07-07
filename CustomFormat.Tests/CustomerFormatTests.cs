using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomFormat;

namespace CustomFormat.Tests
{
    [TestFixture]
    public class CustomerFormatTests
    {
        [TestCaseSource("GetParams")]
        public string Format_Tests(string str, object arg, IFormatProvider provider)
        {
            CustomerFormat cp = new CustomerFormat();
            return cp.Format(str, arg, provider);
        }
        public IEnumerable<TestCaseData> GetParams()
        {
            Customer c = new Customer("Igar", 101214, "+12345678911");
            yield return new TestCaseData("p", c, null).Returns("+1 (234) 567-8911 ");
            yield return new TestCaseData("np", c, null).Returns("Igar ,+1 (234) 567-8911 ");
            yield return new TestCaseData("n", c, null).Returns("Igar ");
            yield return new TestCaseData("r", c, null).Returns("101214 ");
            yield return new TestCaseData("rp", c, null).Returns("+1 (234) 567-8911 ,101214 ");
            yield return new TestCaseData("rn", c, null).Returns("Igar ,101214 ");
            yield return new TestCaseData("rnp", c, null).Returns("Igar ,+1 (234) 567-8911 ,101214 ");
            yield return new TestCaseData("rnp", null, null).Throws(typeof( ArgumentNullException));
            yield return new TestCaseData("t", c, null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData(null, c, null).Throws(typeof(ArgumentNullException));
            yield return new TestCaseData(null, null, null).Throws(typeof(ArgumentNullException));
           
        }
    }

}
