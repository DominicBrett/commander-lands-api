using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class LandDomain(ILandRepository landRepository) : ILandDomain
    {
        private readonly string[] _possibleColors = ["red", "blue", "green", "white", "red"];
        public List<LandTypeCollection> GetLandTypeCollections(string[] colors)
        {
            var excludedColors = _possibleColors.Where(x => !colors.Contains(x)).ToArray();
            var lands = landRepository.GetLands(colors, excludedColors).OrderBy(x => x.Type.Priority);
            var landsTypeCollections = new List<LandTypeCollection>();

            var i = -1;
            var previousLandPriority = 0;
            foreach (var land in lands)
            {
                if (land == null) continue;

                var landType = land.Type;
                var currLandTypePriority = landType.Priority;

                if (currLandTypePriority != previousLandPriority)
                {
                    landsTypeCollections.Add(new LandTypeCollection() { Lands = [], LandType = landType });
                    i++;
                }
                landsTypeCollections[i].Lands.Add(land);
            }
            return landsTypeCollections;
        }
    }
}
