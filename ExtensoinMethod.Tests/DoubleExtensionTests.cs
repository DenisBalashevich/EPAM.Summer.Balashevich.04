using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ExtensoinMethod;
namespace ExtensoinMethod.Tests
{
    [TestFixture]
    public class DoubleExtensionTests
    {
        [TestCaseSource("ToIEEE754TestData")]
        public string Format_Tests(double x)
        {
            return DoubleExtension.ToIEEE754(x);
        }
        public IEnumerable<TestCaseData> ToIEEE754TestData()
        {
            yield return new TestCaseData(123.4).Returns("0000000100111101100110111001100110011001100110011001100101011001");
            yield return new TestCaseData(0.00000001).Returns("0001111101010001010011110111000101000111000000110011000100010111");
            yield return new TestCaseData(12365625.265554654).Returns("0100000101110011101010011110011100000101011111110001101101001111");
            yield return new TestCaseData(0.0).Returns("0000000000000000000000000000000000000000000000000000000000000000");
        }
    }

}
