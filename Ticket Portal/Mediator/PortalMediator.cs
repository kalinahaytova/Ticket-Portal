using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.Mediator.Abstractions;
using Ticket_Portal.Mediator.Participant;

namespace Ticket_Portal.Mediator
{
    public class PortalMediator : IPortalMediator
    {
        private NextUser nextUser;
        private FinishUser finishUser;

        public FinishUser FinishUser
        {
            set { finishUser = value; }
        }

        public NextUser NextUser
        {
            set { nextUser = value; }
        }

        public override void Send(string message, User user)
        {
            if(user == nextUser)
            {
                nextUser.Recieve(message);
            }
            else
            {
                finishUser.Recieve(message);
            }
        }
    }
}
