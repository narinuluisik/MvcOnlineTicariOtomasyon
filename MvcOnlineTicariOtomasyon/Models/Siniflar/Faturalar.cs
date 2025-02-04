using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Faturalar
    {
        [Key]
        public int Faturaid { get; set; }
        public string FaturaSeriNp { get; set; }
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public string Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }

        public ICollection<FaturaKalem> FaturaKalems { get; set; }
    }
}