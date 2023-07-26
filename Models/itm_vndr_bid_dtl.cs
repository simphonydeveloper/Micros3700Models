using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class itm_vndr_bid_dtl
    {
        public int inven_itm_seq { get; set; }
        public int vndr_seq { get; set; }
        public int bid_unit_seq { get; set; }
        public int itm_vndr_bid_seq { get; set; }
        public DateTime effective_from_date { get; set; }
        public DateTime effective_to_date { get; set; }
        public double min_qty { get; set; }
        public DateTime bid_date { get; set; }
        public string bid_ref_id { get; set; }
        public double? bid_price { get; set; }
        public double maj_unit_price { get; set; }
        public double maj_min_qty { get; set; }
        public string ob_does_not_expire { get; set; }
        public string ob_user_cancelled { get; set; }
        public string ob_cancelled_preferred_vndr { get; set; }
        public DateTime? cancelled_date { get; set; }
        public short? cancelled_ovrde_lead_tm_day { get; set; }
        public short? cancelled_itm_quality_rating { get; set; }
        public string cmnt_ln { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cncy_seq { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
