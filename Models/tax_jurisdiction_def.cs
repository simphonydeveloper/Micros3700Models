using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tax_jurisdiction_def
    {
        public int tax_juris_seq { get; set; }
        public string name { get; set; }
        public int obj_num { get; set; }
    }
}