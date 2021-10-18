﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
    {
    class Ratings
        {
      
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TripId { get; set; }
        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
        }
    }
