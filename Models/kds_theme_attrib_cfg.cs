using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_theme_attrib_cfg
    {
        public int attrib_seq { get; set; }
        public string table_name { get; set; }
        public string key_name { get; set; }
        public string column_name { get; set; }
        public string type { get; set; }
        public int? ord_dvc_seq { get; set; }
    }
}
