using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.FlyWeight;
using Ticket_Portal.Mediator;
using Ticket_Portal.Mediator.Participant;

namespace Ticket_Portal.TicketPortal
{
    public class ReservationProcess
    {
        private readonly List<Event> _events;
        private PurchaseInfo information;
        private readonly PortalMediator mediator;
        private readonly NextUser nextUser;
        private readonly FinishUser finishUser;

        public ReservationProcess(List<Event> events)
        {
            _events = events;
            mediator = new PortalMediator();
            nextUser = new NextUser(mediator);
            finishUser = new FinishUser(mediator);
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
            information = new PurchaseInfo(_events);
            int userCount;
            if(information != null)
            {
                Console.Write("Number of tickets: ");
                userCount = int.Parse(Console.ReadLine());
                
                while(userCount > 0 || userCount <= 0)
                {
                    if (userCount > 0)
                    {
                        for (int i = 0; i < userCount; i++)
                        {
                            information.GetInformation("UserInfo:");
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
                    information.GetTotalTicketPrice(eventID, userCount);

                    mediator.NextUser = nextUser;
                    mediator.FinishUser = finishUser;

                    nextUser.Send("Are you sure you want to continue?");
                    var message = Console.ReadLine();
                    if(message == "Yes")
                    {
                        finishUser.Send(message);
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
                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
