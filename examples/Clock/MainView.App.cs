using NAct.WinForms;

namespace NAct.Examples.Clock
{
    public sealed partial class MainView
    {
        public sealed class App : Component<FormElement>
        {
            public override FormElement Render()
            {
                return new FormElement()
                    .Add(() => new Clock(), nameof(timeLabel));
            }
        }
    }
}
