using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rvc_mlvl_temp
    {
        public int rvc_seq { get; set; }
        public string mlvl_type { get; set; }
        public short mlvl { get; set; }
        public string name { get; set; }
        public string prefix { get; set; }
    }
}
