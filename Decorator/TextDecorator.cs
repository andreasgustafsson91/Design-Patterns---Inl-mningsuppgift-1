using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public abstract class TextDecorator : IText
    {
        public IText Text { get; set; }
        IBaseText baseText = new BaseText();
        public string FirstTag;
        public string SecondTag;

        public TextDecorator(IText text)
        {
            Text = text;
        }

        public string GetFirstTag()
        {
            return FirstTag; /*+ Text.GetInputText();*/
        }

        public string GetSecondTag()
        {
            return /*Text.GetSecondTag() +*/ SecondTag;
        }
    }
}
