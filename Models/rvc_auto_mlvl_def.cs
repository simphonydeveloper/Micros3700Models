using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rvc_auto_mlvl_def
    {
        public int rvc_seq { get; set; }
        public int auto_mlvl_seq { get; set; }
        public int? prd_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? main_mlvl { get; set; }
        public short? sub_mlvl { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
