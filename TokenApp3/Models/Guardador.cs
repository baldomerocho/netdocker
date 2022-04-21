using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TokenApp3.Models
{
    public class Guardador
    { 
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        
        public int Description{ get; set; }
    }
}
