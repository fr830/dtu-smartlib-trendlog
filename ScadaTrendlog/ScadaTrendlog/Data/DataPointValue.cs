using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScadaTrendlog.Data
{
    public class DataPointValue
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int DataPointId { get; set; }

        public DataPoint DataPoint { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime Timestamp { get; set; }

        [Required]
        public double Value { get; set; }
    }
}
