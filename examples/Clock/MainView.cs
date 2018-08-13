using System.Windows.Forms;
using NAct.WinForms;

namespace NAct.Examples.Clock
{
    public sealed partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            WinFormsRenderer.Render(new App(), this);
        }
    }
}
