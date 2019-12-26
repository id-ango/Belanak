using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magnajaya.Models
{
    public class CbTransD
    {
        public int CbTransDId { get; set; }
        [MaxLength(2)]
        public string Kode { get; set; }
        public string NmBank { get; set; }
        public string DocNo { get; set; }
        public string RefNo { get; set; }
        public string NoPrj { get; set; }
        [Column(TypeName = "date")]
        public DateTime Tanggal { get; set; }
        public string Keterangan { get; set; }
        public string Tipe { get; set; }
        public string SrcCode { get; set; }
        public string NamaSrc { get; set; }
        public string GlAcct { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Jumlah { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Terima { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bayar { get; set; }
        public string Kurs { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KJumlah { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KTerima { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KBayar { get; set; }

        public string AcctSet { get; set; }
        public bool NonPPn { get; set; }
        public string Cek { get; set; }
        public int CbTransHId { get; set; }
    }
}

