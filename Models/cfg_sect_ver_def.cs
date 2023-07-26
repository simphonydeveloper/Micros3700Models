using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cfg_sect_ver_def
    {
        public int cfg_sect_seq { get; set; }
        public int cfg_sect_ver_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_default_version { get; set; }
    }
}
