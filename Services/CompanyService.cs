using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Repository;

namespace Services
{
    public class CompanyService: ICompanyService
    {
        protected readonly IRepository _repo;
        public CompanyService(IRepository repo)
        {
            _repo = repo;
        }
        public Task<IEnumerable<Company>> GetAll()
        {
            return _repo.GetAllAsync<Company>(s=>s.OrderBy(a=>a.CompanyName));
        }

        public Company CreateCompany(Company company)
        {
            _repo.Create(company);
            _repo.Save();
            return company;
        }
    }
}
