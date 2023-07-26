using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_theme_def
    {
        public int kds_theme_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string theme_active { get; set; }
    }
}
