using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class SuperScript : TextDecorator, ISuperScript
    {
        public SuperScript(IText text) : base(text)
        {
            string start = "<sup>";
            string end = "</sup>";
            InputText = start;
            SecondTag = end;
        }
    }
}
