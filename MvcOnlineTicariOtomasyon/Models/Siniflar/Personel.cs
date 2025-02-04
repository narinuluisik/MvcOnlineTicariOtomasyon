using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Personel
    {
        [Key]
        public int Personelid { get; set; }
       
         [Display(Name ="Personel Adı")]
        public string PersonelAd { get; set; }
        [Display(Name = "Personel Soyadı")]
        public string PersonelSoyad { get; set; }
        [Display(Name = "Görsel ")]
        public string PersonelGorsel { get; set; }
        public string About { get; set; }
        public string Adress { get; set; }
        public string No { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int Departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}