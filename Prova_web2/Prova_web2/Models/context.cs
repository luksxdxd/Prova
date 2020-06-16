using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova_web2.Models
{
    public class context : DbContext
    {
        public DbSet<operario> operarios { get; set; }
    }
}