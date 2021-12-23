using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class Bold : TextDecorator, IBold
    {
        public Bold(IText text) : base(text)
        {
            string start = "<b>";
            string end = "</b>";
            InputText = start;
            SecondTag = end;
        }
    }
}
