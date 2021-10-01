using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        [Owner("ViniciusA")]
        public void CreatePerson_OfTypeEmployeeTest()
        {
            PersonManager PerMgr = new PersonManager();
            Person per;

            per = PerMgr.CreatePerson("Vinicius", "Andrade", false);

            Assert.IsInstanceOfType(per, typeof(Employee));
             
        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void DoEmployeeExistTest()
        {
            Supervisor super = new Supervisor();
            super.Employees = new List<Employee>();
            super.Employees.Add(new Employee()
            {
                FirstName = "Vinicius",
                LastName = "Andrade"
            });

            Assert.IsTrue(super.Employees.Count > 0);

        }
    }
}
