using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses.PersonClasses;

namespace MyClassesTest
{
    [TestClass]
    public class CollectionAssertClassTest
    {
        [TestMethod]
        [Owner("ViniciusA")]
        public void AreCollectionEqualFailsBecauseNoComparerTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Vinicius", LastName = "Andrade" });
            peopleExpected.Add(new Person() { FirstName = "Laura", LastName = "Antonia" });
            peopleExpected.Add(new Person() { FirstName = "Thiago", LastName = "Paulo" });

            //You shall not pass!!
            peopleActual = PerMgr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual);

        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void AreCollectionEqualWithComparerTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleExpected.Add(new Person() { FirstName = "Vinicius", LastName = "Andrade" });
            peopleExpected.Add(new Person() { FirstName = "Laura", LastName = "Antonia" });
            peopleExpected.Add(new Person() { FirstName = "Thiago", LastName = "Paulo" });

            //You shall not pass!!
            peopleActual = PerMgr.GetPeople();

            CollectionAssert.AreEqual(peopleExpected, peopleActual,
                Comparer<Person>.Create((x, y) =>
                x.FirstName == y.FirstName && x.LastName == y.LastName ? 0: 1));

        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void AreCollectionEquivalentTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleExpected = new List<Person>();
            List<Person> peopleActual = new List<Person>();

            peopleActual = PerMgr.GetPeople();

            peopleExpected.Add(peopleActual[1]);
            peopleExpected.Add(peopleActual[2]);
            peopleExpected.Add(peopleActual[0]);

            CollectionAssert.AreEquivalent(peopleExpected, peopleActual);

        }

        [TestMethod]
        [Owner("ViniciusA")]
        public void IsCollectionOfTypeTest()
        {
            PersonManager PerMgr = new PersonManager();
            List<Person> peopleActual = new List<Person>();

            peopleActual = PerMgr.GetSuperVisor();

            CollectionAssert.AllItemsAreInstancesOfType(peopleActual, typeof(Supervisor));

        }
    }
}
