using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_account_def
    {
        public int cm_account_seq { get; set; }
        public string account_name { get; set; }
        public int account_number { get; set; }
        public short? account_type { get; set; }
    }
}
