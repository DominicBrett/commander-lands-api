using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Land
    {
        public required string Name { get; set; }
        public required string[] Colors { get; set; }
    }
}
