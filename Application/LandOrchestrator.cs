using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class LandOrchestrator(ILandDomain landDomain) : ILandOrchestrator
    {
        public List<LandTypeCollection> GetLandTypeCollections(string[] colors)
        {
            // validation here
            return landDomain.GetLandTypeCollections(colors);
        }
    }
}
