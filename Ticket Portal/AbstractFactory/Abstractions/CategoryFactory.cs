using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_Portal.AbstractFactory.Abstractions
{
    public abstract class CategoryFactory
    {
        public abstract List<Event> GetEvents();
    }
}
