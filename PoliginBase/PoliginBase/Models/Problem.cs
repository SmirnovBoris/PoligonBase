using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PoliginBase.Models
{
    public class Problem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        public string Format { get; set; }
        
        [DataType(DataType.MultilineText)]
        [Required]
        public string Config { get; set; }

    }
}