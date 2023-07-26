using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_loc_def
    {
        public int inven_loc_seq { get; set; }
        public int inven_itm_ilcg_seq { get; set; }
        public string itm_position { get; set; }
        public int? itm_position_num { get; set; }
        public string ob_dflt { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
