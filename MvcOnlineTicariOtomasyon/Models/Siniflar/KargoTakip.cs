using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class KargoTakip
    {
        [Key]
        public int KargoTakipid { get; set; }
        public string TakipKodu { get; set; }
        public string Açiklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}