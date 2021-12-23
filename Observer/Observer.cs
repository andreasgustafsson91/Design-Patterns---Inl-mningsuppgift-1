using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Observer
    {
        public void Update(string email)
        {
            Console.WriteLine($"The current mail says \"{email}\"");
        }
    }
}
