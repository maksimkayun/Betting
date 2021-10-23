using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Position
    {
        public Position() {
            this.Players = new HashSet<Player>();
        }
        [Key] 
        public int PositionId { get; set; }

        [Required] 
        public string Name { get; set; }
        
        public virtual ICollection<Player> Players { get; set; }
    }
}