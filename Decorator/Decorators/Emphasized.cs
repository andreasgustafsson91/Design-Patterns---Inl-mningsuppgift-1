using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Emphasized : TextDecorator, IEmphasized
    {
        public Emphasized(IText text) : base(text)
        {
            string start = "<em>";
            string end = "</em>";
            InputText = start;
            SecondTag = end;
        }
    }
}
