using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cfg_sect_def
    {
        public int cfg_sect_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int em_table_reg_seq { get; set; }
        public string ob_lc_sect { get; set; }
        public int? section_def_seq { get; set; }
    }
}
