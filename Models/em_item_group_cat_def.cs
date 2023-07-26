using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_item_group_cat_def
    {
        public int group_cat_seq { get; set; }
        public string group_cat_name { get; set; }
        public string group_cat_desc { get; set; }
    }
}
