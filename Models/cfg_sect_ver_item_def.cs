using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cfg_sect_ver_item_def
    {
        public int cfg_sect_seq { get; set; }
        public int cfg_sect_ver_seq { get; set; }
        public int cfg_sect_ver_item_seq { get; set; }
        public int? ref_cfg_sect_ver_seq { get; set; }
        public int? ref_cfg_sect_seq { get; set; }
        public string inclusion { get; set; }
        public int? def_seq { get; set; }
    }
}
