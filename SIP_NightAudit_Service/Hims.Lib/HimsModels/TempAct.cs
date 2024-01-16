﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class TempAct
    {
        public int RecordId { get; set; }
        public string MemberId { get; set; }
        public string Client { get; set; }
        public DateTime TermDate { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
    }
}