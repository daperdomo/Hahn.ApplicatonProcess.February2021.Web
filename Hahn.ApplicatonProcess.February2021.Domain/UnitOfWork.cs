using Hahn.ApplicatonProcess.February2021.Data.DataAccess;
using Hahn.ApplicatonProcess.February2021.Data.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IServiceProvider serviceProvider;

        public UnitOfWork(IServiceProvider _serviceProvider)
        {
            serviceProvider = _serviceProvider;
        }


        private IAssetService _assetService;

        public IAssetService AssetService
        {
            get
            {
                return _assetService = _assetService ?? serviceProvider.GetService<IAssetService>();
            }
        }
    }
}
