using System;
using System.Windows.Forms;
using NAct.WinForms;

namespace NAct.Examples.Clock
{
    public sealed class Clock : Component<LabelElement>
    {
        // Need analyzers:
        // Private get-only State property to enable shorter syntax in Render
        // All other properties represent props and must be auto-properties with public getter and public setter.
        // All fields must be private and readonly. This way, updating the component state can only be done via state.Set.

        private readonly Timer timer = new Timer { Interval = 1000 };
        private readonly ComponentState<DateTime, Clock> state;
        private DateTime State => state.Value;

        public Clock()
        {
            state = DateTime.Now;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public override void Dispose()
        {
            timer.Dispose();
            base.Dispose();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            state.Set((prevState, props) => DateTime.Now);
        }

        public override LabelElement Render()
        {
            return new LabelElement($"It is {State:t}");
        }
    }
}
