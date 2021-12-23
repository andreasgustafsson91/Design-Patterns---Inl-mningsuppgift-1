using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Important : TextDecorator, IImportant
    {
        public Important(IText text) : base(text)
        {
            string start = "<strong>";
            string end = "</strong>";
            FirstTag = start;
            SecondTag = end;
        }
    }
}
