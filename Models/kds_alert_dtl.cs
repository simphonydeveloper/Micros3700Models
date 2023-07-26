using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_alert_dtl
    {
        public int kds_alert_seq { get; set; }
        public string kds_trans_id { get; set; }
        public short? ord_dvc_seq { get; set; }
        public short? course { get; set; }
        public DateTime? alert_time { get; set; }
        public short? alert_level { get; set; }
    }
}
