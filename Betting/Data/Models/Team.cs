using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Team
    {
        public Team() {
            this.GamesAway = new HashSet<Game>();
            this.GamesHome = new HashSet<Game>();
            this.Players = new HashSet<Player>();
        }
        
        [Key]
        public int TeamId { get; set; }
        
        [Required]
        public decimal Budget { get; set; }
        
        [Required]
        public string Initials { get; set; }

        [Required, MaxLength(128)] 
        public string Name { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string LogoUrl { get; set; }
        
        [ForeignKey("Color")]
        public int? PrimaryKitColorId { get; set; }
        //public int? SecondaryKitColorId { get; set; }
        public virtual Color ColorPrimary { get; set; }
        
        
        [ForeignKey("Color")]
        public int? SecondaryKitColorId { get; set; }
        public virtual Color ColorSecondary { get; set; }
        
        [ForeignKey("Town")]
        public int? TownId { get; set; }
        public virtual Town Town { get; set; }
        
        public virtual ICollection<Game> GamesAway { get; set; }
        
        public virtual ICollection<Game> GamesHome { get; set; }
        
        public virtual ICollection<Player> Players { get; set; }
    }
}