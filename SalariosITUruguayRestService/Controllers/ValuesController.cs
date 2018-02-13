using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Domain;
using Services;

namespace SalariosITUruguayRestService.Controllers
{
    public class ValuesController : ApiController
    {
        protected readonly ICompanyService companyService;
        public ValuesController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                var companies = await companyService.GetAll();
                return Ok(companies);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return InternalServerError();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post(string name)
        {
            try
            {
                var company = new Company {CompanyName = name};
                companyService.CreateCompany(company);
                return Ok(company);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return InternalServerError();
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
