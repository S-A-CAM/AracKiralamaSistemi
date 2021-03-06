﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs
{
    public class IstekDTO
    {
        public int istekID { get; set; }
        public int musteriID { get; set; }

        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public string telNo { get; set; }
        public string aracMarka { get; set; }
        public string aracModel { get; set; }
        public int aracID { get; set; }
        public Nullable<System.DateTime> baslangicTarihi { get; set; }
        public Nullable<System.DateTime> bitisTarihi { get; set; }
        public Nullable<bool> durum { get; set; }

    }
}
