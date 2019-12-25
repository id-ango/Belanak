using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Magnajaya.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string TaxName { get; set; }
       
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string GlAccount1 { get; set; }
        public string GlAccount2 { get; set; }
        public string GlAccount3 { get; set; }
        public string GlAccount4 { get; set; }
        public string GlAccount5 { get; set; }
        public string GlAccount6 { get; set; }

    }
}
