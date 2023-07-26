using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class im_parameter_purge_def
    {
        public int store_id { get; set; }
        public int table_seq { get; set; }
        public short purge_aging { get; set; }
        public short aging_default { get; set; }
    }
}
