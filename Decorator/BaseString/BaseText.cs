using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class BaseText : IBaseText
    {
        public string SecondTag { get; set; }
        public string InputText { get; set; }
        public BaseText()
        {
            InputText = "";
            SecondTag = "";
        }

        public string GetInputText()
        {
            return InputText;
        }

        public string GetSecondTag()
        {
            return SecondTag;
        }
    }
}
