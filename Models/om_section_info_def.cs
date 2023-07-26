using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_section_info_def
    {
        public int section_info_seq { get; set; }
        public int section_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string caption { get; set; }
        public int? mi_seq { get; set; }
        public int? text_color { get; set; }
        public int? bkgrd_color { get; set; }
        public int? outline_color { get; set; }
        public decimal? price_adjustment { get; set; }
    }
}
