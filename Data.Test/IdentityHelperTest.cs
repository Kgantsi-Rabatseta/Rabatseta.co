using System;
using Data.Helpers;
using Data.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data.Test
{
    [TestClass]
    public class IdentityHelperTest
    {
        [TestMethod]
        public void TestIdentity()
        {
            var idNumber = "9111195306085";
            var identity = new SysIdentity(idNumber);

            Assert.AreEqual("Male", identity.Gender);
            Assert.AreEqual(identity.IdNumber,idNumber);
            Assert.AreEqual("1991-11-19", identity.DateOfBirth.ToString());
        }


        [TestMethod]
        public void TestDateOfBirth()
        {
            var id = "9107220306085";
            DateOfBirth dob = new DateOfBirth(id);

            Assert.AreEqual("1991-07-22",dob.ToString());
            Assert.AreEqual("July",dob.Month);
            Assert.AreEqual(dob.MonthOfBirth,7);
            Assert.AreEqual(dob.YearOfBirth,1991);
            Assert.AreEqual(dob.DayOfBirth,22);

        }
    }
}
