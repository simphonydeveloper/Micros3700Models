using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_transaction_dtl
    {
        public decimal transaction_seq { get; set; }
        public int transaction_receptacle_seq { get; set; }
        public DateTime? transaction_time { get; set; }
        public DateTime? business_date { get; set; }
        public int? transaction_employee_seq { get; set; }
        public int? transaction_type { get; set; }
        public int? target_receptacle_seq { get; set; }
        public int? workstation_id { get; set; }
        public int? affected_employee_seq { get; set; }
        public int? workstation_drawer_id { get; set; }
        public int? cm_item_seq { get; set; }
        public int? res_item_id { get; set; }
        public decimal? base_item_amt { get; set; }
        public int? count_seq { get; set; }
        public int? count_dtl_seq { get; set; }
        public decimal? frgn_item_amt { get; set; }
        public int? pos_transaction_id { get; set; }
        public int? count_item_seq { get; set; }
        public int? count_unit_seq { get; set; }
        public string reason { get; set; }
        public string ob_reconciled { get; set; }
        public decimal? pos_base_item_amt { get; set; }
        public int? cm_account_seq { get; set; }
        public int? cm_vendor_seq { get; set; }
        public string reference_doc { get; set; }
        public string description { get; set; }
        public DateTime? invoice_date { get; set; }
        public decimal? invoice_amt { get; set; }
        public string invoice_desc { get; set; }
        public DateTime? transaction_time_loc { get; set; }
        public int? rvc_seq { get; set; }
        public decimal? vat_amt { get; set; }
    }
}
