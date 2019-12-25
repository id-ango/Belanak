using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magnajaya.Models
{
    public class CbTransH
    {
        public int CbTransHId { get; set; }
        [MaxLength(2)]
        public string Kode { get; set; }
        public string Docno { get; set; }
        public string NoPrj { get; set; }
        public string RefNo { get; set; }
        public string Keterangan { get; set; }
        public string Tanggal { get; set; }
        public string AcctSet { get; set; }
        public string Supplier { get; set; }
        public string Customer { get; set; }
        public string Giro { get; set; }
        public DateTime TglGiro { get; set; }
        public string NamaGiro { get; set; }
        public string NamaCust { get; set; }
        public DateTime TglCair { get; set; }
        public DateTime TglGiro2 { get; set; }
        public decimal Saldo { get; set; }
        public decimal Debet { get; set; }
        public decimal Kredit { get; set; }
        public string Kurs { get; set; }
        public decimal KDebet { get; set; }
        public decimal KKredit { get; set; }
        public bool NonPPn { get; set; }
        public string Cek { get; set; }
    }
}

  