using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_server_rvc_status
    {
        public int emp_seq { get; set; }
        public int rvc_seq { get; set; }
        public DateTime? unavailable_tm { get; set; }
        public short? unavailable_minutes { get; set; }
        public short? unavailable_assignments { get; set; }
    }
}
