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
        public string FirstTag { get; set; }
        public BaseText()
        {
            FirstTag = "";
            SecondTag = "";
        }

        public string GetFirstTag()
        {
            return FirstTag;
        }

        public string GetSecondTag()
        {
            return SecondTag;
        }
    }
}
