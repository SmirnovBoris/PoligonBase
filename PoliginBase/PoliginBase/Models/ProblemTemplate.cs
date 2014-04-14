using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PoliginBase.Models
{
    public class ProblemTemplate
    {
        [DataType(DataType.Text)]
        public string name { get; set; }

        [DataType(DataType.MultilineText)]
        public string format { get; set; }
        
        [DataType(DataType.MultilineText)]
        public string config { get; set; }

    }
}