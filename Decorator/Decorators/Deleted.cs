using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Deleted : TextDecorator, IDeleted
    {
        public Deleted(IText text) : base(text)
        {
            string start = "<del>";
            string end = "</del>";
            FirstTag = start;
            SecondTag = end;
        }
    }
}
