using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities
{
    public class Customer : Entity
    {
        //[Key]
        //public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerPassword { get; set; }
    }
}
