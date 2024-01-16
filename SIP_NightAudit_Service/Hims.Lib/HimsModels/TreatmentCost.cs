﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class TreatmentCost
    {
        public int ProviderId { get; set; }
        public int TreatmentId { get; set; }
        public decimal? Cost { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}
