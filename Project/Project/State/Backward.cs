namespace Project
{
    class Backward : State
    {
        Singleton _singleton;

        public Backward()
        {
            _singleton = Singleton.GetInstance();
        }
        public override bool HandleForward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
        }
        public override bool HandleBackward()
        {
            return false;
        }
        public override bool HandleLeft()
        {
            return false;
        }
        public override bool HandleRight()
        {
            return false;
        }
        public override bool HandleLeftForward()
        {
            return false;
        }
        public override bool HandleRightForward()
        {
            return false;
        }
        public override bool HandleRightBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To RightBackward");
            this._context.TransitionTo(new RightBackward());
            return true;
        }
        public override bool HandleLeftBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To LeftBackward");
            this._context.TransitionTo(new LeftBackward());
            return true;
        }
    }
}
