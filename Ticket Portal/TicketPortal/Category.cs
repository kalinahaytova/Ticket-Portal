using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.AbstractFactory.Events;

namespace Ticket_Portal.TicketPortal
{
    public class Category
    {
        List<Event> events;
        private readonly CategoryFactory concert = new Concert();
        private readonly CategoryFactory culture = new Culture();
        private readonly CategoryFactory family = new Family();
        private readonly CategoryFactory sport = new Sport();
        private readonly CategoryFactory other = new Other();
       

        public List<Event> ChooseCategory(string categoryName)
        {
            while(categoryName != null)
            {
                if(categoryName == concert.GetType().Name)
                {
                    CategoryManage categoryManage = new CategoryManage(concert);
                    categoryManage.GetEventInfo();
                    events = concert.GetEvents();
                    break;
                }
                else if(categoryName == culture.GetType().Name)
                {
                    CategoryManage categoryManage = new CategoryManage(culture);
                    categoryManage.GetEventInfo();
                    events = culture.GetEvents();
                    break;
                }
                else if (categoryName == family.GetType().Name)
                {
                    CategoryManage categoryManage = new CategoryManage(family);
                    categoryManage.GetEventInfo();
                    events = family.GetEvents();
                    break;
                }
                else if (categoryName == sport.GetType().Name)
                {
                    CategoryManage categoryManage = new CategoryManage(sport);
                    categoryManage.GetEventInfo();
                    events = sport.GetEvents();
                    break;
                }
                else if (categoryName == other.GetType().Name)
                {
                    CategoryManage categoryManage = new CategoryManage(other);
                    categoryManage.GetEventInfo();
                    events = other.GetEvents();
                    break;
                }
                else
                {
                    Console.WriteLine("Please, choose event category: ");
                    categoryName = Console.ReadLine();
                }
            }
            return events;
        }
    }
}
