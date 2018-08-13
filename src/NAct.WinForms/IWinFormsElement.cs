using System.Windows.Forms;

namespace NAct.WinForms
{
    public interface IWinFormsElement<in TTarget> where TTarget : Control
    {
    }
}
