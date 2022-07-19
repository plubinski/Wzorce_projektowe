namespace Project
{
    class Forward : State
    {
        Singleton _singleton;

        public Forward()
        {
            _singleton = Singleton.GetInstance();
        }

        public override bool HandleForward()
        {
            return false;
        }
        public override bool HandleBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To LeftForward");
            this._context.TransitionTo(new LeftForward());
            return true;
        }
        public override bool HandleRightForward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To RightForward");
            this._context.TransitionTo(new RightForward());
            return true;
        }
        public override bool HandleRightBackward()
        {
            return false;
        }
        public override bool HandleLeftBackward()
        {
            return false;
        }
    }
}
