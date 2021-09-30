using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassesTest
{
    [TestClass]
    public class StringAssertClassTest
    {
        [TestMethod]
        [Owner("ViniciusA")]
        public void ContainsTest()
        {
            string str1 = "Vinicius Andrade";
            string str2 = "Andrade";

            StringAssert.Contains(str1, str2);
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void StartsWithTest()
        {
            string str1 = "Todos Caixa Alta";
            string str2 = "Todos Caixa";

            StringAssert.StartsWith(str1, str2);
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void IsAllLoweCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            StringAssert.Matches("todos caixa", reg);
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void IsNotAllLoweCaseTest()
        {
            Regex reg = new Regex(@"^([^A-Z])+$");

            StringAssert.DoesNotMatch("Todos Caixa", reg);
        }
    }
}
