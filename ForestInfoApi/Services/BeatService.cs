using ForestInfoApi.Data;
using ForestInfoApi.Interfaces;
using ForestInfoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForestInfoApi.Services
{
    public class BeatService : RepositoryService<Beat>, IBeatData
    {
        public BeatService(ForestInfoContext db) : base(db)
        {
        }
    }
}
