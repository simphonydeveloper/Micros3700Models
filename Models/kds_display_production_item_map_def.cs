using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_display_production_item_map_def
    {
        public int dvc_tbl_seq { get; set; }
        public int production_item_seq { get; set; }
        public int? obj_num { get; set; }
        public string persistence { get; set; }
    }
}
