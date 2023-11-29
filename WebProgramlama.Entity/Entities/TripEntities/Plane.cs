using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities.TripEntities
{
    public class Plane : BaseEntitiy.BaseEntity
    {
        public string PlaneModel { get; set; }
        public List<Seat> Seats { get; set; }
    }
}
