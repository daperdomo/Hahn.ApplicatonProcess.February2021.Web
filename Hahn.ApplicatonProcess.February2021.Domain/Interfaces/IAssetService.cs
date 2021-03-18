using Hahn.ApplicatonProcess.February2021.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Interfaces
{
    public interface IAssetService
    {
        IEnumerable<Asset> ListAll();
        Asset GetById(int Id);
    }
}
