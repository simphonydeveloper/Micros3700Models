using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_password_def
    {
        public int emp_pass_seq { get; set; }
        public int emp_seq { get; set; }
        public string emp_pwd { get; set; }
        public DateTime create_date { get; set; }
        public string old_version_emp_pwd { get; set; }
    }
}
