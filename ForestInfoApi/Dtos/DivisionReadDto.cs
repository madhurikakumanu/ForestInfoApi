using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Range = ForestInfoApi.Models.Range;

namespace ForestInfoApi.Dtos
{
    public class DivisionReadDto
    {
        public int DivisionCode { get; set; }
        public string DivisionName { get; set; }
        public decimal ForestArea { get; set; }
        public decimal GrossArea { get; set; }

        public ICollection<Range> Ranges { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Beat> Beats { get; set; }
        public ICollection<Block> Blocks { get; set; }
        public ICollection<Compartment> Compartments { get; set; }
    }
}
