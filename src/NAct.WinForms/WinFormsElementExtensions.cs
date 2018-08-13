using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NAct.WinForms
{
    public static class WinFormsElementExtensions
    {
        public static TParent Add<TParent, TChild>(this TParent container, Expression<Func<Component<TChild>>> childComponentFactory, string nameofTargetControl)
            where TParent : IWinFormsParentElement<Control>
            where TChild : IWinFormsElement<Control>
        {
            return (TParent)container.Add(childComponentFactory, nameofTargetControl);
        }
    }
}
