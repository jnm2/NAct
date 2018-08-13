using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NAct.WinForms
{
    public sealed class FormElement : IWinFormsElement<Form>, IWinFormsParentElement<Control>
    {
        IWinFormsParentElement<Control> IWinFormsParentElement<Control>.Add<TChild>(Expression<Func<Component<TChild>>> childComponentFactory, string nameofTargetControl)
        {
            throw new NotImplementedException();
        }
    }
}
