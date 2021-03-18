using Hahn.ApplicatonProcess.February2021.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hahn.ApplicatonProcess.February2021.Domain.ViewModel
{
    public class AssetViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string AssetName { get; set; }
        public Department Department { get; set; }
        public string CountryOfDepartment { get; set; }
        public string EMailAdressOfDepartment { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Broken { get; set; }
    }
}
