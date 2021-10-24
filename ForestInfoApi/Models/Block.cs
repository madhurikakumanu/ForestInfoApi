using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Models
{
    public class Block
    {
        [Key]
        [Required]
        public int BlockCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string BlockDescription { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal ForestArea { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal GrossArea { get; set; }
        

        public Division Division { get; set; }
        public Range Range { get; set; }
        public ICollection<Compartment> Compartments { get; set; }
    }
}
