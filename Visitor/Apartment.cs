using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Apartment : IRoom
    {
        private readonly IEnumerable<IRoom> rooms;

        public Apartment()
        {
            rooms = new List<IRoom>
            {
                new Kitchen(),
                new Bathroom(),
                new Kitchen()
            };
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var room in  rooms)
            {
                room.Accept(visitor);
            }
        }

        public string GetName()
        {
            return "Apartment";
        }
    }
}
