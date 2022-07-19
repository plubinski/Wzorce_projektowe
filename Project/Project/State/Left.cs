namespace Project
{
    class Left : State
    {
        Singleton _singleton;

        public Left()
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
            return false;
        }
        public override bool HandleRight()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
        }
        public override bool HandleLeftForward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To LeftForward");
            this._context.TransitionTo(new LeftForward());
            return true;
        }
        public override bool HandleRightForward()
        {
            return false;
        }
        public override bool HandleRightBackward()
        {
            return false;
        }
        public override bool HandleLeftBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To LeftBackward");
            this._context.TransitionTo(new LeftBackward());
            return true;
        }
    }
}
