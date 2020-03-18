using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchify.Data.Models
{
    class LunchEvent
    {
        public int Id { get; set; }
        public User Host { get; set; }
        public Lunch Lunch { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public DateTime EventDate { get; set; }

    }
}
