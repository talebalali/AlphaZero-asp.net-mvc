using AlphaZero.Data.Base;
using AlphaZero.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Data.Services
{ 
    public class MobilesService : EntityBaseRepository<Mobile>, IMobilesService
    {
        

        public MobilesService(AppDbContext context): base(context) { }






    }
}
