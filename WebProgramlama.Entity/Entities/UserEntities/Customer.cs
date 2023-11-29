using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities.UserEntities
{
    public class Customer : Entity.Entities.BaseEntitiy.BaseEntity
    {
        //[Key]
        //public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
    }
}
