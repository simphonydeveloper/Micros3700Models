using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class order_dev_linkage_def
    {
        public int ord_dvc_seq { get; set; }
        public int ord_linkage_seq { get; set; }
    }
}
