using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vega.Persistence;
using Vega.Controllers.Resources;
using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;

        }

        //api/Features
        [HttpGet("/api/features")]
         public async Task<IEnumerable<FeatureResource>> GetFeatures(){


            var feature = await context.Features.ToListAsync();

            return mapper.Map<List<Feature>,List<FeatureResource>>(feature);

        }
    }
}