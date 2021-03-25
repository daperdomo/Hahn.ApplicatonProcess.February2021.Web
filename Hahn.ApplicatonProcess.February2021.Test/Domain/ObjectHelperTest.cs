using Hahn.ApplicatonProcess.February2021.Domain.Helpers;
using Hahn.ApplicatonProcess.February2021.Test.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Test.Domain
{
    public class ObjectHelperTest : BaseTest
    {
        private IObjectHelper _objectHelper;

        [SetUp]
        public void Setup()
        {
            base.SetUp();

            _objectHelper = (IObjectHelper)_services.GetService(typeof(IObjectHelper));
        }


        [Test]
        [TestCase("2021-05-15")]
        public void IsNotOlderThanOneYear(DateTime dateTime)
        {
            bool isNotOlder = _objectHelper.IsNotOlderThanOneYear(dateTime);
            Assert.IsTrue(isNotOlder);
        }

        [Test]
        [TestCase("2022-05-15")]
        public void IsOlderThanOneYear(DateTime dateTime)
        {
            bool isNotOlder = _objectHelper.IsNotOlderThanOneYear(dateTime);
            Assert.IsFalse(isNotOlder);
        }
    }
}
