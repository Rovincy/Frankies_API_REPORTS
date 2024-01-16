﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Hims.Lib.HimsModels
{
    public partial class AccountTransaction
    {
        public long TransactionId { get; set; }
        public DateTime DateTransaction { get; set; }
        public short TypeTransaction { get; set; }
        public string Description { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public int? ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public short Cancelled { get; set; }
        public string UserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public short? PaymentType { get; set; }
        public string VoucherNo { get; set; }
        public long? BatchId { get; set; }
    }
}
