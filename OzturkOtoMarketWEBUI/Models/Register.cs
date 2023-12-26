using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OzturkOtoMarketWEBUI.Models
{
    public class Register
    {
        public int Id { get; set; } 

        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("E posta adresiniz")]
        [EmailAddress(ErrorMessage ="E posta adresinizi düzgün giriniz.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreleriniz Uyuşmuyor")]
        public string RePassword { get; set; }
    }
}