namespace Project
{
    class Right : State
    {
        Singleton _singleton;

        public Right()
        {
            _singleton = Singleton.GetInstance();
        }

        public override bool HandleForward()
        {
            return false;
        }
        public override bool HandleBackward()
        {
            return false;
        }
        public override bool HandleLeft()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To RightForward");
            this._context.TransitionTo(new RightForward());
            return true;
        }
        public override bool HandleRightBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To RightBackward");
            this._context.TransitionTo(new RightBackward());
            return true;
        }
        public override bool HandleLeftBackward()
        {
            return false;
        }
    }
}
