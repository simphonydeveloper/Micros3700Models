using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class isl_file_def
    {
        public int isl_file_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string path_name { get; set; }
        public string file_name { get; set; }
        public string content { get; set; }
        public UInt16? hash_size { get; set; }
        public string hash_data { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
        public DateTime? dev_mode_date { get; set; }
    }
}
