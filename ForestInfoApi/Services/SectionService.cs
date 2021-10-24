using ForestInfoApi.Data;
using ForestInfoApi.Interfaces;
using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Services
{
    public class SectionService : RepositoryService<Section>, ISectionData
    {
        public SectionService(ForestInfoContext db) : base(db)
        {
        }
    }
}
