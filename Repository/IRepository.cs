using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR.ADS.HR.Models
{
    public interface IRepository
    {
        IEnumerable<EmployeeDetails> getEmpDetails();


    }
}
