using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Helpers
{
    public class ObjectHelper : IObjectHelper
    {
        public bool IsNotOlderThanOneYear(DateTime? date)
        {
            DateTime today = DateTime.Today;

            if (date == null || date < today)
                return false;

            DateTime zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = date.Value - today;
            int years = (zeroTime + span).Year - 1;
            return years < 1;
        }
    }
}
