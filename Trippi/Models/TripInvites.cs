﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TripInvites
    {
        public int Id { get; set; }
        public int ToUserId { get; set; }
        public int FromUserId { get; set; }
        public int TripId { get; set; }
        public int Status { get; set; }
    }
}
