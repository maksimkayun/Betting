using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Town
    {
        public Town() {
            this.Teams = new HashSet<Team>();
        }
        [Key] 
        public int TownId { get; set; }
        
        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
        
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
    }
}