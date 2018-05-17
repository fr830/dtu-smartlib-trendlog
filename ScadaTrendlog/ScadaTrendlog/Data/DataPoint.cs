using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ScadaTrendlog.Data
{
    public class DataPoint
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Display(Name = "Lokation")]
        public Location Location { get; set; }

        public ICollection<DataPointValue> TrendlogValues { get; set; }
    }
}
