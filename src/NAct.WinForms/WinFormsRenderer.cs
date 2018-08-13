using System;
using System.Windows.Forms;

namespace NAct.WinForms
{
    public static class WinFormsRenderer
    {
        public static void Render<TElement, TControl>(Component<TElement> component, TControl root)
            where TElement : IWinFormsElement<TControl>
            where TControl : Control
        {
            if (component == null) throw new ArgumentNullException(nameof(component));
            if (root == null) throw new ArgumentNullException(nameof(root));

            throw new NotImplementedException();
        }
    }
}
