using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SR.ADS.HR.Models
{
    public class EmployeeRepository : EmployeeDetails, IRepository
    {
  
        public IEnumerable<EmployeeDetails> getEmpDetails()
        {
            try
            {
                List<EmployeeDetails> details = new List<EmployeeDetails>();
                details.Add(new EmployeeDetails() { EmpNo = "Su9897Y", Id = 1, Name = "Anand" });
                details.Add(new EmployeeDetails() { EmpNo = "S90722", Id = 2, Name = "Kumar" });
                details.Add(new EmployeeDetails() { EmpNo = "S911220", Id = 3, Name = "David" });
                details.Add(new EmployeeDetails() { EmpNo = "Smlvv9", Id = 4, Name = "Alex" });

                return details;
            }
            catch (Exception ex)
            {
                //Log your exception
                throw ex;
            }
        }

  
    }
}