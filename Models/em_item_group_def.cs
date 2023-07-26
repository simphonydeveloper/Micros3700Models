using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_item_group_def
    {
        public int item_group_seq { get; set; }
        public string group_name { get; set; }
        public string group_desc { get; set; }
        public int? secondary_category { get; set; }
        public int? primary_category { get; set; }
    }
}
