﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlama.Entity.Entities.BaseEntitiy
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
