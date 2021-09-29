using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests
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
        #endregion

        #region AreSame/AreNotSame Tests
        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }


        #endregion

        #region IsInstanceOfType Test
        [TestMethod]
        [Owner("ViniciusA")]
        public void IsInstanceOfTypeTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("Vinicius", "Andrade", true);

            Assert.IsInstanceOfType(per, typeof(Supervisor));
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void IsNullTest()
        {
            PersonManager mgr = new PersonManager();
            Person per;

            per = mgr.CreatePerson("", "Andrade", true);

            Assert.IsNull(per);
        }

        #endregion

    }

}
