using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NAct.WinForms
{
    public interface IWinFormsParentElement<out TChildTarget> where TChildTarget : Control
    {
        IWinFormsParentElement<TChildTarget> Add<TChild>(Expression<Func<Component<TChild>>> childComponentFactory, string nameofTargetControl) where TChild : IWinFormsElement<Control>;
    }
}
