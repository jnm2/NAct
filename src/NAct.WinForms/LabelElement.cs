using System.Windows.Forms;

namespace NAct.WinForms
{
    public sealed class LabelElement : IWinFormsElement<Control>
    {
        public LabelElement(string text)
        {
            Text = text;
        }

        public string Text { get; }
    }
}
