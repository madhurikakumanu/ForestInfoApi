using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Dtos
{
    public class DivisionCreateDto
    {
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string DivisionName { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal ForestArea { get; set; }

        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal GrossArea { get; set; }

    }
}
