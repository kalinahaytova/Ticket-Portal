using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.FlyWeight;
using Ticket_Portal.Mediator;

namespace Ticket_Portal.TicketPortal
{
    public class ReservationProcess
    {
        private readonly List<Event> _events;
        private PurchaseInfo info;
        private readonly PortalMediator mediator;
        private readonly ConcreteUser concreteUser;
        public ReservationProcess(List<Event> events)
        {
            _events = events;
            mediator = new PortalMediator();
            concreteUser = new ConcreteUser(mediator);
        }
        public void EventById(int eventID)
        {
            for(int i=0; i<_events.Count; i++)
            {
                if(_events[i].ID == eventID)
                {
                    if(_events[i].StartDate > new DateTime(2021, 6, 1) || _events[i].EndDate > new DateTime(2021, 6, 1))
                    {
                        if(_events[i].StartDate < new DateTime(2021, 6, 24) || _events[i].EndDate < new DateTime(2021, 6, 24))
                        {
                            Console.WriteLine("The event has either been cancelled or is already over.");
                            eventID = int.Parse(Console.ReadLine());
                            i = -1;
                        }
                        else
                        {
                            Console.Clear();
                            GetInformation(eventID);
                            break;
                        }
                    }
                }
                if (eventID > _events.Count || eventID < 0)
                {
                    Console.WriteLine("Wrong ID");
                    eventID = int.Parse(Console.ReadLine());
                    i = -1;
                }
            }
        }
        public void GetInformation(int eventID)
        {
            info = new PurchaseInfo(_events);
            int userCount;
            if(info != null)
            {
                Console.Write("Number of tickets: ");
                userCount = int.Parse(Console.ReadLine());
                
                while(userCount > 0 || userCount <= 0)
                {
                    if (userCount > 0)
                    {
                        for (int i = 0; i < userCount; i++)
                        {
                            info.GetInformation("User Info:");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You haven't chosen tickets correctly.");
                        userCount = int.Parse(Console.ReadLine());
                    }
                }

                Console.Clear();

                if(userCount > 0)
                {
                    info.GetTotalTicketPrice(eventID, userCount);

                    mediator.ConcreteUser = concreteUser;

                    concreteUser.Send("Are you sure you want to continue?");
                    var message = Console.ReadLine();
                    if(message == "Yes")
                    {
                        concreteUser.Send(message);
                    }
                    else if (message == "No")
                    {
                        Console.Clear();
                        Console.Write("What kind of event are you looking for: ");
                        string eventName = Console.ReadLine();

                        Category category = new Category();

                        List<Event> events = category.ChooseCategory(eventName);

                        Console.WriteLine("Choose an event: ");
                        int neweventID = int.Parse(Console.ReadLine());

                        ReservationProcess reservationProcess = new ReservationProcess(events);
                        reservationProcess.EventById(neweventID);
                    }
                    else
                    {
                        Console.WriteLine("Error.");
                    }
                }
                Console.WriteLine("Something went wrong.");
            }
        }

    }
}
