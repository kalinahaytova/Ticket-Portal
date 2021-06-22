using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Portal.Mediator.Abstractions
{
    public abstract class User
    {
        protected PortalMediator mediator;

        public User(PortalMediator portal)
        {
            this.mediator = portal;
        }
    }
}
