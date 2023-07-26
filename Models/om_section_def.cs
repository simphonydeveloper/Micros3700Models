using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class om_section_def
    {
        public int section_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public short? num_sections { get; set; }
        public short? main_shape { get; set; }
    }
}
