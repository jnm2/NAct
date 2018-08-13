using System;
using System.ComponentModel;

namespace NAct
{
    public abstract class Component<TRender> : IDisposable
    {
        internal event EventHandler StateChanged;
        internal object State { get; private set; }

        public abstract TRender Render();

        public virtual void Dispose()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected sealed class ComponentState<TState, TProps>
        {
            private TState value;

            public ComponentState(TState value)
            {
                this.value = value;
            }

            public TState Value => value;

            public void Set(StateUpdater<TState, TProps> calculateNewState)
            {
                if (calculateNewState == null) throw new ArgumentNullException(nameof(calculateNewState));
            }

            public static implicit operator ComponentState<TState, TProps>(TState initialState)
            {
                return new ComponentState<TState, TProps>(initialState);
            }
        }

        protected delegate TState StateUpdater<TState, TProps>(TState prevState, TProps props);
    }

}
