using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Interfaces
{
    public interface IAssetService
    {
        IEnumerable<AssetViewModel> ListAll();
        AssetViewModel GetById(int Id);
        AssetViewModel Create(AssetViewModel model);
        AssetViewModel Update(AssetViewModel model);
        void Delete(int Id);
    }
}
