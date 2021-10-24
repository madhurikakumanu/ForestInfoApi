using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Models
{
    public class Compartment
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CompartmentCode { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal NetForestArea { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal GrossForestArea { get; set; }
       
        public Division Division { get; set; }
        public Range Range { get; set; }
        public Block Block { get; set; }
    }
}
