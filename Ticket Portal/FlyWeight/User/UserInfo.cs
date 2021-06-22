using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Ticket_Portal.FlyWeight.Interface;

namespace Ticket_Portal.FlyWeight.Info
{
    public class UserInfo : Information
    {
        public string GetInfo()
        {
            Console.Write("Enter your name: ");
            string user = Console.ReadLine();

            Console.Write("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();
            bool flag = false;

            Regex regexPhone = new Regex(@"^0[8-9][7-9][0-9]{7}$");
            Match matchPhone = regexPhone.Match(phoneNumber);

            while (flag == false)
            {
                if (!matchPhone.Success)
                {
                    Console.WriteLine("Invalid phone number! Try again: ");
                    phoneNumber = Console.ReadLine();
                    matchPhone = regexPhone.Match(phoneNumber);
                }
                else
                {
                    flag = true;
                }
            }

            Console.Write("Enter your e-mail: ");
            string email = Console.ReadLine();
            bool isEmailValid = false;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            while (isEmailValid == false)
            {
                if (!match.Success)
                {
                    Console.WriteLine("Invalid e-mail! Try again: ");
                    email = Console.ReadLine();
                    match = regex.Match(email);
                }
                else
                {
                    isEmailValid = true;
                }
            }

            return user + " " + phoneNumber + " " + email;

        }

        public string GetInformation()
        {
            throw new NotImplementedException();
        }
    }
}
