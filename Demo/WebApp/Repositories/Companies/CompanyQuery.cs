﻿
                    
      
     
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Repository.Pattern.Repositories;
using Repository.Pattern.Ef6;
using WebApp.Models;

namespace WebApp.Repositories
{
   public class CompanyQuery:QueryObject<Company>
    {
        public CompanyQuery WithAnySearch(string search)
        {
            if (!string.IsNullOrEmpty(search))
                And( x =>  x.Id.ToString().Contains(search) || x.Name.Contains(search) || x.Address.Contains(search) || x.City.Contains(search) || x.Province.Contains(search) || x.RegisterDate.ToString().Contains(search) || x.Employees.ToString().Contains(search) );
            return this;
        }
    }
}



