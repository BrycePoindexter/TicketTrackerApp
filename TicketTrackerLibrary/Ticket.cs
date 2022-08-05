using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketTrackerLibrary
{
    /*
     * Models a Ticket data structure.
     */
    public class Ticket
    {
        private static short UNSET = -1;
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public DateTime CreateTime { get; }
        public DateTime UpdateTime { get; }
        public bool IsResolved { get; set; }

        // TODO: ADD ATTATCHMENT SUPPORT.

        public Ticket()
        {
            this.Id = UNSET;
            this.Name = "";
            this.Description = "";
            this.Author = new User();
            this.CreateTime = DateTime.Now;
            this.UpdateTime = DateTime.Now;
            this.IsResolved = false;
        }

        public Ticket(long Id, string name, string description, User author)
        {
            this.Id = Id;
            this.Name = name;
            this.Description = description;
            if (author != null)
            {
                this.Author = author;
            } else
            {
                this.Author = new User();
            }
            this.CreateTime = DateTime.Now;
            this.UpdateTime = DateTime.Now;
            this.IsResolved = false;
        }
    }
}