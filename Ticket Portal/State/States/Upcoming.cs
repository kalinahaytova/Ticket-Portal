using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.State.Abstractions;

namespace Ticket_Portal.State.States
{
    public class Upcoming : IPortalState
    {
        public static Upcoming state = null;
        public Upcoming()
        {

        }
        public static Upcoming GetUpcoming()
        {
            if(state == null)
            {
                state = new Upcoming();
            }
            return state;
        }
        public override void State()
        {
            Console.WriteLine("Upcoming event on: ");
        }
    }
}
