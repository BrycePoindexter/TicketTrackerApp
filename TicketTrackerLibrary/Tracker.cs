using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTrackerLibrary
{
    public class Tracker
    {
        public List<Ticket> TicketList { get; set; }
        public List<User> UserList { get; set; }

        public Tracker()
        {
            TicketList = new List<Ticket>();
            UserList = new List<User>();
        }
    }
}
