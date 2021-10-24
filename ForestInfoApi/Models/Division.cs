using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Models
{
    public class Division
    {
        [Key]
        [Required]
        public int DivisionCode { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string DivisionName { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal ForestArea { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal GrossArea { get; set; }

        public ICollection<Range> Ranges { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Beat> Beats { get; set; }
        public ICollection<Block> Blocks { get; set; }
        public ICollection<Compartment> Compartments { get; set; }
    }
}
