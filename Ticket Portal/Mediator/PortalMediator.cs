using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.Mediator.Abstractions;

namespace Ticket_Portal.Mediator
{
    public class PortalMediator : IPortalMediator
    {
        private ConcreteUser concreteUser;

        public ConcreteUser ConcreteUser
        {
            set { concreteUser = value; }
        }

        public override void Send(string message, User user)
        {
            if(user == concreteUser)
            {
                concreteUser.Recieve(message);
            }
        }
    }
}
