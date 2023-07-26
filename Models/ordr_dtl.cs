using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ordr_dtl
    {
        public int ordr_seq { get; set; }
        public string name { get; set; }
        public double? itm_adjmt { get; set; }
        public double? othr_adjmt { get; set; }
        public double? ordr_ttl { get; set; }
        public double? itm_ttl { get; set; }
        public int? vndr_seq { get; set; }
        public short? stat { get; set; }
        public DateTime? rqstd_del_date { get; set; }
        public DateTime? place_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cncy_seq { get; set; }
        public double? itm_ttl_base { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
