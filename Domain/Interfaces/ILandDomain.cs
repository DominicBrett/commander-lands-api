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
        Task<List<LandTypeCollection>> GetLandTypeCollections(string[] colors);
    }
}