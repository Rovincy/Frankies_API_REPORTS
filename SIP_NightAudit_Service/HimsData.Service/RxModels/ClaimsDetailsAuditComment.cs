﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class ClaimsDetailsAuditComment
    {
        public long Id { get; set; }
        public string ProviderId { get; set; }
        public string Claimno { get; set; }
        public string Comment { get; set; }
        public string InsCompany { get; set; }
    }
}
