using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LandTypeCollection
    {
        public required LandType LandType { get; set; }
        public required List<Land> Lands { get; set; }
    }
}
