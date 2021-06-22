using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.State.Abstractions;

namespace Ticket_Portal.State.States
{
    public class Ended : IPortalState
    {
        public static Ended state = null;
        public Ended()
        {

        }
        public static Ended GetEnded()
        {
            if(state == null)
            {
                state = new Ended();
            }
            return state;
        }
        public override void State()
        {
            Console.WriteLine("Sorry, this event is over.");
        }
    }
}
