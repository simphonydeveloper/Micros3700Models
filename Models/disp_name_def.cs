using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class disp_name_def
    {
        public string disp_tbl_id { get; set; }
        public int disp_seq_num { get; set; }
        public int disp_lang_seq { get; set; }
        public string disp_name { get; set; }
        public int? disp_opt_tbl_seq { get; set; }
    }
}
