﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class BatchViewDetailed
    {
        public int BatchId { get; set; }
        public int? BookNo { get; set; }
        public DateTime BatchDate { get; set; }
        public DateTime? PayDate { get; set; }
        public string ClaimType { get; set; }
        public decimal AmountReceived { get; set; }
        public decimal? AmountPaid { get; set; }
        public string Remarks { get; set; }
        public DateTime ClaimMonth { get; set; }
        public short Status { get; set; }
        public DateTime? DateOfCompletion { get; set; }
        public DateTime? AccountDate { get; set; }
        public string AssignedTo { get; set; }
        public string PaidBy { get; set; }
        public short Resubmitted { get; set; }
        public int ProviderId { get; set; }
        public int? ClientId { get; set; }
        public int CountClaims { get; set; }
        public string StatusString { get; set; }
        public string ResubmittedString { get; set; }
        public string ProviderName { get; set; }
        public string ClientName { get; set; }
        public string ClaimTypeString { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalRejectedAmount { get; set; }
        public decimal TotalSuspendedAmount { get; set; }
        public decimal TotalToBePaid { get; set; }
    }
}
