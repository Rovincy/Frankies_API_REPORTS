﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class Ward
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}