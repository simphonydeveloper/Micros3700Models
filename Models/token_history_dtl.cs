using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class token_history_dtl
    {
        public string security_token { get; set; }
        public DateTime? create_time { get; set; }
    }
}
