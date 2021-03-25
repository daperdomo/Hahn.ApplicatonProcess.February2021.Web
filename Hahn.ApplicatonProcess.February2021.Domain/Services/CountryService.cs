using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Services
{
    public class CountryService : ICountryService
    {
        private readonly AppSettings appSettings;
        public CountryService(IOptions<AppSettings> _appSettings)
        {
            appSettings = _appSettings.Value;
        }
        public bool ExistsCountry(string countryName)
        {
            using var client = new HttpClient();
            var result = client.GetAsync($"{appSettings.CountryServicePath}{countryName}").Result;
            return result.StatusCode == System.Net.HttpStatusCode.OK;
        }
    }
}
