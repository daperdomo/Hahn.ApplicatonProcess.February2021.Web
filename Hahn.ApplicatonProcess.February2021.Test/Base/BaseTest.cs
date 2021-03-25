using Hahn.ApplicatonProcess.February2021.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Test.Base
{
    public class BaseTest
    {
        protected IServiceProvider _services;

        public virtual void SetUp()
        {
            _services = Program.CreateHostBuilder(new string[] { }).Build().Services;
        }
    }
}
