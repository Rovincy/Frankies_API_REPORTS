﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class AuditTableDetail
    {
        public long Id { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ProviderName { get; set; }
        public string InsCompany { get; set; }
        public int? Yrofclaim { get; set; }
        public int? Monthofclaim { get; set; }
        public double? SumOfClaims { get; set; }
        public int? NumberOfClaims { get; set; }
        public double? SumOfClaimsAwarded { get; set; }
        public double? SumOfClaimsRejected { get; set; }
        public int? UserId { get; set; }
        public string PostedBy { get; set; }
    }
}
