using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DataModels
{
    public class LandData : Land
    {
        [Key]
        public int Id { get; set; }
        public int TypeId { get; set; }

        public LandType Type { get; set; }

    }
}