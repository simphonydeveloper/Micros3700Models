using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ap_export_batch_dtl
    {
        public int ap_export_batch_seq { get; set; }
        public DateTime ap_export_date { get; set; }
    }
}
