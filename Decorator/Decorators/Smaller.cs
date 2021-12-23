using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Smaller : TextDecorator, ISmaller
    {
        public Smaller(IText text) : base(text)
        {
            string start = "<small>";
            string end = "</small>";
            FirstTag = start;
            SecondTag = end;
        }
    }
}
