using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.State.Abstractions;
using Ticket_Portal.State.States;

namespace Ticket_Portal.State
{
    public class EventState
    {
        public static IPortalState state;

        public EventState()
        {
            state = Upcoming.GetUpcoming();
        }

        public void EndedEvent()
        {
            state = Ended.GetEnded();
        }
        public void UpcomingEvent()
        {
            state = Upcoming.GetUpcoming();
        }
        public void State()
        {
            state.State();
        }
    }
}
