using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_vendor_def
    {
        public int cm_vendor_seq { get; set; }
        public string vendor_name { get; set; }
        public int obj_num { get; set; }
    }
}
