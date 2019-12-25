using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Magnajaya.Models
{
    public class CbBank
    {
        public int CbBankId { get; set; }
       [MaxLength(2)]
        public string Kode { get; set; }
        [MaxLength(100)]
        public string NmBank { get; set; }

        [Column(TypeName = "decimal(18, 2)")] 
        public decimal SldAwal { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KsldAwal { get; set; }
        [Column(TypeName ="date")]
        public DateTime ClrDate { get; set; }
        [MaxLength(10)]
        public string AcctSet { get; set; }
        [MaxLength(3)]
        public string Kurs { get; set; }
        public bool NonPpn { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Saldo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BankSld { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Debet { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Kredit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KSaldo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KBankSld { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KDebet { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal KKredit { get; set; }

      
    }
}
