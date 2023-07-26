using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rest_cfg_sect_hist_def
    {
        public int store_id { get; set; }
        public int cfg_sect_seq { get; set; }
        public int rest_cfg_sect_hist_seq { get; set; }
        public int? new_cfg_sect_ver_seq { get; set; }
        public int? old_cfg_sect_ver_seq { get; set; }
        public decimal em_chg_set_seq { get; set; }
    }
}
