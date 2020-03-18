using Lunchify.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchify.Data.Services
{
    class InMemoryLunchData : IEntityData<Lunch>
    {
        List<Lunch> lunches;

        public InMemoryLunchData()
        {
            lunches = new List<Lunch>()
            {
                new Lunch {
                            Id = 1,
                            Name = "Pizza",
                            Description = "A margherita pizza with tomato and mozzerella.",
                            Vegetarian = true
                },
                new Lunch {
                            Id = 1,
                            Name = "Cheeseburger",
                            Description = "A double cheeseburger with ketchup and a brioche bun.",
                            Vegetarian = false
                },
                new Lunch {
                            Id = 1,
                            Name = "Lentil Soup",
                            Description = "Spiced red lentil soup made with onions and coconut milk.",
                            Vegetarian = true
                },
            };
        }
        public void Create(Lunch lunch)
        {
            throw new NotImplementedException();
        }

        public void Delete(Lunch lunch)
        {
            throw new NotImplementedException();
        }

        public Lunch Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Lunch> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Lunch lunch)
        {
            throw new NotImplementedException();
        }
    }
}
