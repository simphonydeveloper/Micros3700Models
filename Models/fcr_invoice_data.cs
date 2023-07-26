using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fcr_invoice_data
    {
        public decimal PCWSID { get; set; }
        public string FCRInvNumber { get; set; }
        public decimal MicrosChkNum { get; set; }
        public decimal InvoiceType { get; set; }
        public decimal InSARMode { get; set; }
        public string CustomerID { get; set; }
        public decimal InvoiceStatus { get; set; }
        public DateTime? MicrosBsnzDate { get; set; }
        public DateTime? FCRBsnzDate { get; set; }
        public decimal? Subtotal1 { get; set; }
        public decimal? Subtotal2 { get; set; }
        public decimal? Subtotal3 { get; set; }
        public decimal? Subtotal4 { get; set; }
        public decimal? Subtotal5 { get; set; }
        public decimal? Subtotal6 { get; set; }
        public decimal? Subtotal7 { get; set; }
        public decimal? Subtotal8 { get; set; }
        public decimal? Subtotal9 { get; set; }
        public decimal? Subtotal10 { get; set; }
        public decimal? Subtotal11 { get; set; }
        public decimal? Subtotal12 { get; set; }
        public decimal? TaxTtl1 { get; set; }
        public decimal? TaxTtl2 { get; set; }
        public decimal? TaxTtl3 { get; set; }
        public decimal? TaxTtl4 { get; set; }
        public decimal? TaxTtl5 { get; set; }
        public decimal? TaxTtl6 { get; set; }
        public decimal? TaxTtl7 { get; set; }
        public decimal? TaxTtl8 { get; set; }
        public string ExtraField1 { get; set; }
        public string ExtraField2 { get; set; }
        public string ExtraField3 { get; set; }
        public string ExtraField4 { get; set; }
        public string ExtraField5 { get; set; }
        public string ExtraField6 { get; set; }
        public string ExtraField7 { get; set; }
        public string ExtraField8 { get; set; }
    }
}
