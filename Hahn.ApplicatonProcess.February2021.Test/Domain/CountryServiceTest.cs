using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Hahn.ApplicatonProcess.February2021.Test.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Test.Domain
{
    public class CountryServiceTest : BaseTest
    {
        private ICountryService _countryService;

        [SetUp]
        public void Setup()
        {
            base.SetUp();

            _countryService = (ICountryService)_services.GetService(typeof(ICountryService));
        }

        [Test]
        [TestCase("Dominican republic")]
        public void ExistsCountry(string countryName)
        {
            bool existCountry = _countryService.ExistsCountry(countryName);
            Assert.IsTrue(existCountry);
        }


        [Test]
        [TestCase("Not existed country")]
        public void NotExistsCountry(string countryName)
        {
            bool existCountry = _countryService.ExistsCountry(countryName);
            Assert.IsFalse(existCountry);
        }
    }
}
