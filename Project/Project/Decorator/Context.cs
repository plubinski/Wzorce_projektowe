namespace Project
{
    public class Context : Vehicle
    {
        private State _state = null;

        public Context(State state)
        {
            this._state = state;
            this._state.SetContext(this);
        }

        public override void TransitionTo(State state)
        {
            //Console.WriteLine($"Context: Transition to {state.GetType().Name}.");

            this._state = state;
            this._state.SetContext(this);
        }

        public override State GetState()
        {
            return this._state;
        }

        public override bool GoForward()
        {
            return this._state.HandleForward();
        }
        public override bool GoBackward()
        {
            return this._state.HandleBackward();
        }
        public override bool GoLeft()
        {
            return this._state.HandleLeft();
        }
        public override bool GoRight()
        {
            return this._state.HandleRight();
        }
        public override bool GoLeftForward()
        {
            return this._state.HandleLeftForward();
        }
        public override bool GoRightForward()
        {
            return this._state.HandleRightForward();
        }
        public override bool GoRightBackward()
        {
            return this._state.HandleRightBackward();
        }
        public override bool GoLeftBackward()
        {
            return this._state.HandleLeftBackward();
        }
    }
}
