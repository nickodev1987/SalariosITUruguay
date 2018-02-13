﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAll();

        Company CreateCompany(Company company);
    }
}
