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
        List<LunchEvent> lunchevents;

        public InMemoryLunchEventData()
        {
            lunchevents = new List<LunchEvent>();
        }

        public void Create(LunchEvent lunchevent)
        {
            throw new NotImplementedException();
        }

        public void Delete(LunchEvent lunchevent)
        {
            throw new NotImplementedException();
        }

        public LunchEvent Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LunchEvent> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(LunchEvent lunchevent)
        {
            throw new NotImplementedException();
        }
    }
}
