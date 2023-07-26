using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class ts_current_version_status
    {
        public int? ts_version_seq { get; set; }
        public int? kybd_version_seq { get; set; }
    }
}
