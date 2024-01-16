﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class HealthPlanBenefit
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? PlanId { get; set; }
        public string Benefit { get; set; }
        public string Coverage { get; set; }
        public string Limits { get; set; }
        public int? UserId { get; set; }
    }
}
