﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.Models.SalesReceipt
{
    public class SalesReceiptUpdateModel
    {
        public double TotalPaid { get; set; }
        public bool IsPaidOff { get; set; }
    }
}
