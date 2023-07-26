using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class sales_export_dtl
    {
        public int TRANS_NUM { get; set; }
        public string KEYWORD { get; set; }
        public string TRNSTYPE { get; set; }
        public string BUSINESS_DATE { get; set; }
        public string ACCNT { get; set; }
        public string NAME { get; set; }
        public string AMOUNT { get; set; }
        public string MEMO { get; set; }
        public string CLEAR { get; set; }
        public string TOPRINT { get; set; }
        public string PAID { get; set; }
        public string TAXABLE { get; set; }
        public string EXTRA { get; set; }
    }
}
