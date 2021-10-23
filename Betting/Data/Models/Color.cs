using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Color
    {
        public Color() {
            this.TeamsPrimary = new HashSet<Team>();
            this.TeamsSecondary = new HashSet<Team>();
        }
        [Key] 
        public int ColorId { get; set; }

        [Required] 
        public string Name { get; set; }

        public virtual ICollection<Team> TeamsPrimary { get; set; }
        
        public virtual ICollection<Team> TeamsSecondary { get; set; }
    }
}