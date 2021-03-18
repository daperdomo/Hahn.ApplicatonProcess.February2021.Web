using Hahn.ApplicatonProcess.February2021.Data.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Services
{
    public class AssetService : IAssetService
    {
        private readonly IRepository<Asset> _repository;
        public AssetService(IRepository<Asset> repository)
        {
            _repository = repository;
        }

        public Asset GetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public IEnumerable<Asset> ListAll()
        {
            return _repository.ListAll();
        }
    }
}
