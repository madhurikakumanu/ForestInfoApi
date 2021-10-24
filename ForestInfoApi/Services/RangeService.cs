using ForestInfoApi.Data;
using ForestInfoApi.Interfaces;
using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Range = ForestInfoApi.Models.Range;

namespace ForestInfoApi.Services
{
    public class RangeService : RepositoryService<Range>, IRangeData
    {
        public RangeService(ForestInfoContext db) : base(db)
        {
        }
    }
}
