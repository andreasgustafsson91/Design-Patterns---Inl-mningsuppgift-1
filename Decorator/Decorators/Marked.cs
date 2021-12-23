using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Marked : TextDecorator, IMarked
    {
        public Marked(IText text) : base(text)
        {
            string start = "<mark>";
            string end = "</mark>";
            InputText = start;
            SecondTag = end;
        }
    }
}
