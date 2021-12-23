using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Subject
    {
        public List<Observer> observersList { get; set; } /*new List<Observer>();*/
        public string Email { get; set; }
        public Subject()
        {
            observersList = new();
        }
        public void RegisterObserver(Observer observer)
        {
            observersList.Add(observer);
        }

        public void UnregisterObserver(Observer observer)
        {
            observersList.Remove(observer);
        }

        public void notifyTrue(string email)
        {
            foreach (var observer in observersList)
            {
                observer.Update(email);
            }
        }

        public void notifyFalse()
        {
            foreach (var observer in observersList)
            {
                Console.WriteLine("There is no mail.");
            }
        }
    }
}
