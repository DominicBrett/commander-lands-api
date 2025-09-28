using Application;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("/Lands/")]
    public class LandController(ILandOrchestrator landOrchestrator)
    {
        [HttpGet]
        public Task<List<LandTypeCollection>> GroupedByPriority([FromQuery] string[] colorsProduced)
        {
            return landOrchestrator.GetLandTypeCollections(colorsProduced);
        }
    }
}