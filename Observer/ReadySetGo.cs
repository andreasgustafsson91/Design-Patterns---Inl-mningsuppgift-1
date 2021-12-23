using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment 
{
    class ReadySetGo
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern

            Console.WriteLine("Observer");

            /*var email = "";
            while (string.IsNullOrEmpty(email))
            {
                email = Email.Check();
            }
            Console.WriteLine(email);
            Console.WriteLine();*/

            Subject subject = new Subject();
            Observer observer = new Observer();
            subject.Email = "";

            while (true)
            {
                Console.WriteLine("Press 1 to toggle subscribe.\nPress 2 to check your emails.");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    if (subject.observersList.Contains(observer))
                    {
                        subject.UnregisterObserver(observer);
                        Console.WriteLine("You unsubscribed");
                    }
                    else
                    {
                        subject.RegisterObserver(observer);
                        Console.WriteLine("You subscribed");
                    }
                }
                else if (option == "2")
                {
                    if (!String.IsNullOrEmpty(Email.Check()))
                    {
                        subject.Email = Email.Check();
                        subject.notifyTrue(Email.Check());
                    }
                    else
                    {
                        subject.notifyFalse();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }


        }
    }
}
