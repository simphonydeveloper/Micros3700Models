using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pos_waste_allowance_def
    {
        public int pos_waste_allowance_seq { get; set; }
        public int waste_reason_seq { get; set; }
        public int allowance_seq { get; set; }
    }
}
