using SR.ADS.HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SR.ADS.HR.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IRepository _genericRepository;

        public EmployeeController(IRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public IEnumerable<EmployeeDetails> GetEmployeeDetails()
        {
            return _genericRepository.getEmpDetails();
        }
    }
}
