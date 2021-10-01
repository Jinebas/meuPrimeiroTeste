using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            PersonManager PerMgr = new PersonManager();
            Person per;

            per = PerMgr.CreatePerson("Vinicius", "Andrade", false);

            Assert.IsInstanceOfType(per, typeof(Employee));
             
        }
    }
}
