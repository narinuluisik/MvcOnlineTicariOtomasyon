using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        public string Gönderici { get; set; }
        public string Alıcı { get; set; }
        public string Konu { get; set; }
        public string icerik { get; set; }
        public DateTime Tarih { get; set; }

    }
}