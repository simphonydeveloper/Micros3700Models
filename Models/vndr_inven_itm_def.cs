using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class vndr_inven_itm_def
    {
        public int inven_itm_seq { get; set; }
        public int vndr_seq { get; set; }
        public int bid_unit_seq { get; set; }
        public string vndr_itm_id { get; set; }
        public string ob_preferred_vndr { get; set; }
        public short? ovrde_lead_tm_day { get; set; }
        public short? itm_quality_rating { get; set; }
        public double? maj_last_rcv_price { get; set; }
        public double? last_rcv_price { get; set; }
        public DateTime? last_rcv_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public int? cncy_seq { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string vndr_itm_name { get; set; }
        public string scc_number { get; set; }
        public string itm_brand_name { get; set; }
        public string adtnl_info_1 { get; set; }
        public string adtnl_info_2 { get; set; }
    }
}
