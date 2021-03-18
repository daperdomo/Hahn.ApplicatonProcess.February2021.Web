using Hahn.ApplicatonProcess.February2021.Data.DataAccess;
using Hahn.ApplicatonProcess.February2021.Data.Interfaces;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAssetService AssetService { get; }
    }
}