﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HIMSDATA.Models
{
    public partial class PrintReport
    {
        public int Id { get; set; }
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string MemberNo { get; set; }
        public string CardNum { get; set; }
        public string MemberName { get; set; }
        public string Company { get; set; }
        public string IdCharge { get; set; }
        public string Type { get; set; }
        public string CardSerialNum { get; set; }
        public string Posted { get; set; }
    }
}
