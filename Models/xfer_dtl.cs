using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class xfer_dtl
    {
        public int store_id { get; set; }
        public int xfer_seq { get; set; }
        public int? from_ilcg_seq { get; set; }
        public int? to_ilcg_seq { get; set; }
        public DateTime bus_date { get; set; }
        public DateTime trans_date { get; set; }
        public string xfer_num { get; set; }
        public string xfer_id { get; set; }
        public int xfer_by { get; set; }
        public short stat { get; set; }
        public string items { get; set; }
        public double? xfer_total { get; set; }
        public long? multi_user_access_seq { get; set; }
        public int? vndr_seq { get; set; }
    }
}
