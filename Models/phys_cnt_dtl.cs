using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class phys_cnt_dtl
    {
        public int phys_cnt_seq { get; set; }
        public DateTime cnt_date { get; set; }
        public DateTime? bus_date { get; set; }
        public short state { get; set; }
        public string ob_partial { get; set; }
        public short deflt_sort_ordr { get; set; }
        public int? cnt_by { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_update_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
