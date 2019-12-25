using System;
using System.Collections.Generic;
using System.Text;

namespace Magnajaya.Models
{
    public class CbTransD
    {
        public int CbTransDId { get; set; }
        public string Kode { get; set; }
        public string NmBank { get; set; }
        public string DocNo { get; set; }
        public string RefNo { get; set; }
        public string NoPrj { get; set; }
        public string Tanggal { get; set; }
        public string Keterangan { get; set; }
        public string Tipe { get; set; }
        public string SrcCode { get; set; }
        public string NamaSrc { get; set; }
        public string GlAcct { get; set; }
        public decimal Jumlah { get; set; }
        public decimal Terima { get; set; }
        public decimal Bayar { get; set; }
        public string Kurs { get; set; }
        public decimal KValue { get; set; }
        public decimal KJumlah { get; set; }
        public decimal KTerima { get; set; }
        public decimal KBayar { get; set; }
        public string AcctSet { get; set; }
        public bool NonPPn { get; set; }
        public string Cek { get; set; }
    }
}

