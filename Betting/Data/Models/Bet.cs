using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using Betting.Data.Models.Enums;

namespace Betting.Data.Models
{
    public class Bet
    {
        [Key] public int BetId { get; set; }

        [Required] public decimal Amount { get; set; }
        
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        [Required] public PredictionType Prediction { get; set; } // enum
        
        [Required]
        public DateTime DateTime { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}