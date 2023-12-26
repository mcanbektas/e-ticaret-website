﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.Entity
{
    public enum EnumOrderState
    {
        [Display(Name ="Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Sipariş Tamamlandı")]
        Completed
    }
}