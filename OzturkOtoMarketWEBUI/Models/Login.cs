﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }


        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}