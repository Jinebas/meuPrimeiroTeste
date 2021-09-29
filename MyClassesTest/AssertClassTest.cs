using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        [TestMethod]
        [Owner("ViniciusA")]
        public void AreEqualTest()
        {
            string str1 = "Vinicius";
            string str2 = "Vinicius";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [Owner("ViniciusA")]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "Vinicius";
            string str2 = "vinicius";

            Assert.AreEqual(str1, str2, false);
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void AreNotEqualTest()
        {
            string str1 = "Vinicius";
            string str2 = "Thiago";

            Assert.AreNotEqual(str1, str2);
        }

    }
}
