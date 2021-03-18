using AutoMapper;
using Hahn.ApplicatonProcess.February2021.Data.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
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
        private readonly IMapper _mapper;

        public AssetService(IRepository<Asset> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public AssetViewModel Create(AssetViewModel model)
        {
            var entity = _mapper.Map<Asset>(model);
            _repository.Create(entity);
            _repository.SaveChanges();
            return _mapper.Map<AssetViewModel>(entity);
        }

        public AssetViewModel GetById(int Id)
        {
            return _mapper.Map<AssetViewModel>(_repository.GetById(Id));
        }

        public IEnumerable<AssetViewModel> ListAll()
        {
            return _repository
                .ListAll().
                Select(m => _mapper.Map<AssetViewModel>(m));
        }

        public AssetViewModel Update(AssetViewModel model)
        {
            var entity = _mapper.Map<Asset>(model);
            _repository.Update(entity);
            _repository.SaveChanges();
            return _mapper.Map<AssetViewModel>(entity);
        }

        public void Delete(int Id)
        {
            var entity = _repository.GetById(Id);
            _repository.Delete(entity);
            _repository.SaveChanges();
        }
    }
}
