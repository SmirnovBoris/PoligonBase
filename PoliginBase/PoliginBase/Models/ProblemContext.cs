using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoliginBase.Models
{
    public class ProblemContext : DbContext
    {
        public DbSet<Problem> Problems { get; set; }
    }
}