using System;
using System.Collections.Generic;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.TicketPortal;

namespace Ticket_Portal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket Portal");

            Console.WriteLine();

            Console.WriteLine("Concerts   Culture   Sport   Family   Other");

            Console.WriteLine();

            Console.Write("What kind of event are you looking for: ");
            string categoryName = Console.ReadLine();

            Category category = new Category();

            List<Event> events = category.ChooseCategory(categoryName);

            Console.WriteLine();
            Console.Write("Choose an event: ");
            int eventID = int.Parse(Console.ReadLine());

            ReservationProcess reservationProcess = new ReservationProcess(events);
            reservationProcess.EventById(eventID);
        }
    }
}
