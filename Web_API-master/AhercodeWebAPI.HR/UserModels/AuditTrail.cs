﻿using System;
using System.Collections.Generic;

namespace AhercodeWebAPI.HR.UserModels
{
    public partial class AuditTrail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
