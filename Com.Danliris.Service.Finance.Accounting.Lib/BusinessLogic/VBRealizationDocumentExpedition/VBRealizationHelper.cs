﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.VBRealizationDocumentExpedition
{
    public enum VBRealizationPosition
    {
        [Display(Name = "Pembelian")]
        Purchasing = 1,
        [Display(Name = "Kirim ke Verifikasi")]
        PurchasingToVerification,
        [Display(Name = "Verifikasi")]
        Verification,
        [Display(Name = "Verifikasi ke Kasir")]
        VerifiedToCashier,
        [Display(Name = "Kasir")]
        Cashier,
        [Display(Name = "Ditolak")]
        NotVerified
    }

    public enum VBRealizationExpeditionStatus
    {
        Cashier = 1,
        Return
    }
}
