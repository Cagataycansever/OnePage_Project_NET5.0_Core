using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Announcement
    {
        [Key]
        public int AnnounceId { get; set; }
        public string AnnounceTitle { get; set; }
        public DateTime AnnounceDate { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
    }
}
