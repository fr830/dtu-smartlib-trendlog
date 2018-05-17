using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScadaTrendlog.Data
{
    public class Location
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Lokation")]
        public string Name { get; set; }
    }
}
