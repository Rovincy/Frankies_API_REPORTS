﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SIP_NightAudit_Service.Service.HimsModels
{
    public partial class DrugCategory
    {
        public int DrugCategoryId { get; set; }
        public string Name { get; set; }
        public byte Saleable { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}