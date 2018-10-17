using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Models
{
    class Archive
    {
        public int ItemId { get; set; }
        public string Item { get; set; }
        public DateTime DateFound { get; set; }
        public DateTime DateBrought { get; set; }
        public DateTime DateTaken { get; set; }
        public string Description { get; set; }
    }
}
