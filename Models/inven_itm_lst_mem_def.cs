using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_lst_mem_def
    {
        public int inven_itm_lst_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int? itm_position { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public double? itm_qty { get; set; }
        public int unit_seq { get; set; }
        public int ilcg_seq { get; set; }
        public long? multi_user_access_seq { get; set; }
    }
}
