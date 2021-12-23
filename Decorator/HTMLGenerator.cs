using System;

namespace Design_Patterns_Assignment
{
    public class HTMLGenerator
    {
        public IText Text { get; set; }
        IBaseText baseText = new BaseText();

        public HTMLGenerator()
        {
            Text = baseText;
        }
        public string TagProcessor(string tagSelection, string textInput)
        {

            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');
            foreach (var tag in taglist)
            {
                if (tag=="bold")
                {
                    Text = new Bold(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "deleted")
                {
                    Text = new Deleted(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "emphasized")
                {
                    Text = new Emphasized(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "important")
                {
                    Text = new Important(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "inserted")
                {
                    Text = new Inserted(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "italic")
                {
                    Text = new Italic(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "marked")
                {
                    Text = new Marked(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "smaller")
                {
                    Text = new Smaller(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "subscript")
                {
                    Text = new SubScript(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
                if (tag == "superscript")
                {
                    Text = new SuperScript(Text);
                    textInput = Text.GetFirstTag() + textInput + Text.GetSecondTag();
                }
            }
            return textInput;
        }
    }
}