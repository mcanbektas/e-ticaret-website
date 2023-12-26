using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set;}
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set;}
        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Ürünün Stok Adeti")]
        public int Stock { get; set; }
        [DisplayName("Ürünün Fotoğrafı")]
        public string Image { get; set; }

        [DisplayName("Depoda Var mı ")]
        public bool IsApproved { get; set; }

        public int  CategoryId { get; set; }  
        public Category Category { get; set;}

    }
}