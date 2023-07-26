using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class configurator_data_dtl
    {
        public string group_id { get; set; }
        public int data_index { get; set; }
        public string data { get; set; }
    }
}
