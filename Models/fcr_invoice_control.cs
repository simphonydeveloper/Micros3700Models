using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fcr_invoice_control
    {
        public decimal CtrlID { get; set; }
        public decimal PCWSID { get; set; }
        public decimal InvoiceType { get; set; }
        public string Series { get; set; }
        public decimal? StartInvNum { get; set; }
        public decimal? EndInvNum { get; set; }
        public decimal? Status { get; set; }
        public decimal? CurrInvNum { get; set; }
        public decimal? LockedBy { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string ExtraField1 { get; set; }
        public string ExtraField2 { get; set; }
        public string ExtraField3 { get; set; }
        public string ExtraField4 { get; set; }
    }
}
