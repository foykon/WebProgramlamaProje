using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities
{
    public class Admin : Entity
    {
        //[Key]
        //public int Id { get; set; }
        [Required]
        public string AdminName { get; set; }
        [Required]
        public string AdminPassword { get; set; }
    }
}
