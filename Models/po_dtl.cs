using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class po_dtl
    {
        public int po_seq { get; set; }
        public int? ordr_seq { get; set; }
        public int vndr_seq { get; set; }
        public decimal po_num { get; set; }
        public short po_version_num { get; set; }
        public DateTime po_issue_date { get; set; }
        public int po_issue_by { get; set; }
        public double po_ttl { get; set; }
        public short po_stat { get; set; }
        public string po_prefix { get; set; }
        public string invc_doc_id { get; set; }
        public DateTime? rqstd_del_date { get; set; }
        public DateTime? stat_date { get; set; }
        public short? prn_cnt { get; set; }
        public int? par_ordr_seq { get; set; }
        public int? cncy_seq { get; set; }
        public double? po_ttl_base { get; set; }
        public string cmnt_ln { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
