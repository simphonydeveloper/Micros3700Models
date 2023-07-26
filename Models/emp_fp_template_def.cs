using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_fp_template_def
    {
        public int emp_seq { get; set; }
        public short emp_fp_template_num { get; set; }
        public short? template_length { get; set; }
        public byte[] fp_template { get; set; }
        public short? fp_version { get; set; }
    }
}
