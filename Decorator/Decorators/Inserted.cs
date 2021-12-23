using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Inserted : TextDecorator, IInserted
    {
        public Inserted(IText text) : base(text)
        {
            string start = "<ins>";
            string end = "</ins>";
            FirstTag = start;
            SecondTag = end;
        }
    }
}
