using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class state_def
    {
        public int cntry_seq { get; set; }
        public int state_seq { get; set; }
        public string lookup_value { get; set; }
        public string name { get; set; }
        public string EM_GUID { get; set; }
    }
}
