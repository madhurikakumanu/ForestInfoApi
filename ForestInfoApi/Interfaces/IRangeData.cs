using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Range = ForestInfoApi.Models.Range;

namespace ForestInfoApi.Interfaces
{
    public interface IRangeData : IRepository<Range>
    {
    }
}
