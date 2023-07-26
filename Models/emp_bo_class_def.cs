using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_bo_class_def
    {
        public int emp_bo_class_seq { get; set; }
        public string name { get; set; }
        public string html { get; set; }
        public int? priv_lvl { get; set; }
    }
}
