﻿using System;
using System.Collections.Generic;

namespace AhercodeWebAPI.HR.UserModels
{
    public partial class RoomPrice
    {
        public int Id { get; set; }
        public int? RoomId { get; set; }
        public decimal? Price { get; set; }
    }
}
