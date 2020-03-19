using Lunchify.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchify.Data.Services
{
    class InMemoryLunchEventData : IEntityData<LunchEvent>
    {
        public List<LunchEvent> lunchEvents;

        public InMemoryLunchEventData()
        {

        }

        public LunchEvent Get(int id)
        {
            return lunchEvents.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<LunchEvent> GetAll()
        {
            return lunchEvents.OrderBy(l => l.Id);
        }

        public void Create(LunchEvent lunchEvent)
        {
            lunchEvents.Add(lunchEvent);
            lunchEvent.Id = lunchEvents.Max(l => l.Id) + 1;
        }

        public void Update(LunchEvent lunchEvent)
        {
            var existing = Get(lunchEvent.Id);
            if (existing != null)
            {
                existing.Host = lunchEvent.Host;
                existing.Lunch = lunchEvent.Lunch;
                existing.Location = lunchEvent.Location;
                existing.Capacity = lunchEvent.Capacity;
            }
        }

        public void Delete(int id)
        {
            var lunchEvent = lunchEvents.FirstOrDefault(l => l.Id == id);
            if (lunchEvent != null)
            {
                lunchEvents.Remove(lunchEvent);
            }
        }
    }
}
