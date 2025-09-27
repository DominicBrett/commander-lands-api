using Domain.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILandDomain
    {
        List<LandTypeCollection> GetLandTypeCollections(string[] colors);
    }
}
