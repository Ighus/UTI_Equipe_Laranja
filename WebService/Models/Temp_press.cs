using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    public class temp_press
    {
        [Key]
        public Int64 id { get; set; }
        public double temperatura { get; set; }
        public int pressao1 { get; set; }
        public int pressao2 { get; set; }

    }
}