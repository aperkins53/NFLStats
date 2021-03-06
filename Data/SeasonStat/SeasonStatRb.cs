﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SeasonStatRb
    {
        [Key]
        public int RbSeasonId { get; set; }

        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int RushingYards { get; set; }
        [Required]
        public int RushingAttempts { get; set; }
        [Required]
        public int ReceivingYards { get; set; }
        [Required]
        public int Receptions { get; set; }
        [Required]
        public int RushingTouchdowns { get; set; }
        [Required]
        public int ReceivingTouchdowns { get; set; }
        [Required]
        public int Fumbles { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public int PlayerNumber { get; set; }
        [Required]
        public string Team { get; set; }

    }
}
