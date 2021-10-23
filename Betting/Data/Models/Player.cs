using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Player
    {
        public Player() {
            this.PlayerStatistics = new HashSet<PlayerStatistic>();
        }
        [Key] 
        public int PlayerId { get; set; }

        [Required] 
        public bool IsInjured;

        [Required, MaxLength(64)] 
        public string Name { get; set; }

        [ForeignKey("Position")]
        public int? PositionId { get; set; }
        public virtual Position Position { get; set; }
        
        [Required]
        public int SquadNumber { get; set; }

        [ForeignKey("Team")] 
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
        
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}