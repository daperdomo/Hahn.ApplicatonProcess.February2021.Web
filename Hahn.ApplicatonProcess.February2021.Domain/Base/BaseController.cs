using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Base
{
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;

        protected IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitOfWork = _unitOfWork ?? (IUnitOfWork)this.HttpContext.RequestServices.GetService(typeof(IUnitOfWork));
            }
        }

    }
}
