﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.RxModels
{
    public partial class EmployerList
    {
        public string EmployerName { get; set; }
        public string EmployerNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string Product { get; set; }
        public string RenewalMonth { get; set; }
        public string BenefitMap { get; set; }
    }
}
