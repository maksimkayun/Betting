﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Country
    {
        public Country() {
            this.Towns = new HashSet<Town>();
        }
        [Key] 
        public int CountryId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public virtual ICollection<Town> Towns { get; set; }
    }
}