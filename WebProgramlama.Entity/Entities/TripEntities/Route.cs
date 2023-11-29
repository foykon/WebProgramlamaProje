using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities.TripEntities
{
    public class Route : BaseEntitiy.BaseEntity
    {
        public City CityFrom { get; set; }
        public City CityTo { get; set; }

        public Plane Plane { get; set; }

    }
}
