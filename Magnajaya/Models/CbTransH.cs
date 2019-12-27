using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Magnajaya.Models;

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
        [Column(TypeName = "date")]
        public DateTime Tanggal { get; set; }
        public string AcctSet { get; set; }
        public string Supplier { get; set; }
        public string Customer { get; set; }
        public string Giro { get; set; }
        [Column(TypeName = "date")]
        public DateTime TglGiro { get; set; }
        public string NamaGiro { get; set; }
        public string NamaCust { get; set; }
        [Column(TypeName = "date")]
        public DateTime TglCair { get; set; }
        [Column(TypeName = "date")]
        public DateTime TglGiro2 { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Debet { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Kredit { get; set; }
        [MaxLength(3)]
        public string Kurs { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KDebet { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KKredit { get; set; }
        public bool NonPPn { get; set; }
        public string Cek { get; set; }
        public CbTransD CbTransD { get; set; }

        public string NamaBank (List<CbBank> bank)
        {
            string kode;
            kode = Kode;
            var namabank = bank.Find(s => s.Kode == kode).NmBank;            

            return namabank;
        }


    }

    
}

  