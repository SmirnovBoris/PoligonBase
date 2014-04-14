using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PoliginBase.Models
{
    public class ProblemTemplateContext
    {
        public DbSet<ProblemTemplate> Problems { get; set; }
    }
}