using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hr_cntct_def
    {
        public int hr_cntct_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string menu_desc { get; set; }
        public string doc_loc { get; set; }
    }
}
