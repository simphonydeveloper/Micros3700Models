using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_theme_product_item_map_def
    {
        public int kds_theme_seq { get; set; }
        public int dvc_tbl_seq { get; set; }
        public int production_item_seq { get; set; }
        public string persistence { get; set; }
    }
}
