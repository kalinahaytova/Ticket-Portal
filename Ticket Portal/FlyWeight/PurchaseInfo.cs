using System;
using System.Collections.Generic;
using System.Text;
using Ticket_Portal.AbstractFactory.Abstractions;
using Ticket_Portal.FlyWeight.Info;
using Ticket_Portal.FlyWeight.Interface;

namespace Ticket_Portal.FlyWeight
{
    public class PurchaseInfo 
    {
        private readonly Dictionary<string, Information> purchaseInfos = new Dictionary<string, Information>();
        private readonly List<Event> _events;
        private readonly List<string> usersInfo = new List<string>();
        string userInfo;

        public PurchaseInfo(List<Event> events)
        {
            _events = events;
        }

        public Information GetInformation(string infoType)
        {
            Information information = null;

            if (purchaseInfos.ContainsKey(infoType))
            {
                information = purchaseInfos[infoType];
                userInfo = information.GetInformation();
                usersInfo.Add(userInfo);
            }
            else
            {
                if(infoType == "UserInfo")
                {
                    information = new UserInfo();
                    userInfo = information.GetInformation();
                    usersInfo.Add(userInfo);
                    purchaseInfos.Add(infoType, information);
                }
            }
            return information;
        }

        public void GetTotalTicketPrice(int ID, int userCount)
        {
            double totalPriceSum = 0;

            for(int i = 0; i<_events.Count; i++)
            {
                if(_events[i].ID == ID)
                {
                    totalPriceSum = userCount * _events[i].Price;

                    Console.WriteLine("Event: {0}", _events[i].Gig);
                    Console.WriteLine("From: {0}", _events[i].StartDate);
                    Console.WriteLine("To: {0}", _events[i].EndDate);
                    Console.WriteLine("Where: {0}", _events[i].Location);
                    Console.WriteLine("Price: {0}", _events[i].Price + "$");
                }
            }

            Console.WriteLine();

            for(int i=0; i<usersInfo.Count; i++)
            {
                Console.WriteLine("Your information: {0}", usersInfo[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Total Price: {0}", Math.Round(totalPriceSum, 2) + "$");
            Console.WriteLine();
        }

    }
}
