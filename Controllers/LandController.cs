using Application;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace commander_lands_api.Controllers
{
    [ApiController]
    [Route("/Lands/")]
    public class LandController(ILandOrchestrator landOrchestrator)
    {
        [HttpGet]
        public List<LandTypeCollection> GroupedByPriority([FromQuery] string[] colorsProduced)
        {
            return landOrchestrator.GetLandTypeCollections(colorsProduced);
        } 
    }
}
