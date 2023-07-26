using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class expo_tray_status
    {
        public int expo_tray_seq { get; set; }
        public UInt16? expo_tray_num { get; set; }
        public UInt16? expo_tray_pos { get; set; }
        public string in_use { get; set; }
        public int? expo_tray_area_seq { get; set; }
        public string last_in_use { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
