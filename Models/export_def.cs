using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class export_def
    {
        public int export_seq { get; set; }
        public int? obj_num { get; set; }
        public string name { get; set; }
        public string export_file { get; set; }
        public string delimeter { get; set; }
    }
}
