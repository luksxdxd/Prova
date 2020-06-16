using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace provaWeb2tt2.Models
{
    public class Context : DbContext
    {
        public DbSet<Operario> Operarios { get; set; }
    }
}