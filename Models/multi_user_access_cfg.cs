using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class multi_user_access_cfg
    {
        public int form_seq { get; set; }
        public string form_class_name { get; set; }
        public string executable_name { get; set; }
        public string table_name { get; set; }
        public string seq_col_name { get; set; }
        public string datasource_name { get; set; }
        public string ds_seq_col_name { get; set; }
        public string visible_btns { get; set; }
        public string ob_show_msg { get; set; }
        public string ob_form_caption { get; set; }
        public string ob_allow_read_only { get; set; }
        public string ob_controlled { get; set; }
        public long? multi_user_access_seq { get; set; }
        public string ob_maint_form { get; set; }
    }
}
