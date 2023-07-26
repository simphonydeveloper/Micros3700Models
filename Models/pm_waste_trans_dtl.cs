using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pm_waste_trans_dtl
    {
        public int waste_seq { get; set; }
        public int emp_seq { get; set; }
        public int rvc_seq { get; set; }
    }
}
