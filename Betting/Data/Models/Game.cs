using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Betting.Data.Models
{
    public class Game
    {
        public Game() {
            this.Bets = new HashSet<Bet>();
        }
        [Key] public int GameId { get; set; }
        
        [Required]
        public decimal AwayTeamBetRate { get; set; }

        [Required] 
        public decimal AwayTeamGoals { get; set; }

        [ForeignKey("Team")] 
        public int? AwayTeamId { get; set; }
        public virtual Team AwayTeam { get; set; }
        
        [ForeignKey("Team")] 
        public int? HomeTeamId { get; set; }
        public virtual Team HomeTeam { get; set; }
        
        [Required]
        public decimal HomeTeamBetRate { get; set; }
        
        [Required]
        public decimal HomeTeamGoals { get; set; }

        // [ForeignKey("Team")] 
        // public int HomeTeamId { get; set; }
        // public virtual Team HomeTeam { get; set; }

        [Required] public DateTime DateTime { get; set; }
        
        [Required]
        public string Result { get; set; }
        
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        
        public virtual ICollection<Bet> Bets { get; set; }
    }
}