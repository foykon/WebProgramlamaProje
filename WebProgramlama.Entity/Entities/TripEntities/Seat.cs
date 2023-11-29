using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities.TripEntities
{
    public class Seat : BaseEntitiy.BaseEntity
    {
        public int SeatNumber { get; set; }
        public bool IsNotReserved { get; set; }
        public int SeatPrice { get; set; }
    }
}
