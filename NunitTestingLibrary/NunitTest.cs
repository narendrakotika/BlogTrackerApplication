using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using DataAccessLayer;

namespace NunitTestingLibrary
{
   
        [TestFixture]

        internal class NunitTest
        {
            [Test]
            public void checkEmployeeExistWithNunit()
            {
                var obj = new EmpInfoRepository();
                var res = obj.GetEmpInfo("Abc@gmail.com");
                Assert.That(res, Is.Not.Null);
            }
            [Test]
            public void checkEmployeeCreateWithNunit()
            {
                EmpInfo emp = new EmpInfo
                {
                    Name = "ABC",
                    EmailId = "ABC@gmail.com",
                    PassCode = 234231,
                    DateOfJoining = DateTime.Now,
                };
                var obj = new BlogDbContext();
                EmpInfo res = obj.EmpInfo.Add(emp);
                obj.SaveChanges();
                ClassicAssert.AreEqual(emp.Name, res.Name);
                ClassicAssert.AreEqual(emp.EmailId, res.EmailId);
            }
        }
}