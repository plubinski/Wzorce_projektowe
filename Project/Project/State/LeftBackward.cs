namespace Project
{
    class LeftBackward : State
    {
        Singleton _singleton;

        public LeftBackward()
        {
            _singleton = Singleton.GetInstance();
        }

        public override bool HandleForward()
        {
            return false;
        }
        public override bool HandleBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Backward");
            this._context.TransitionTo(new Backward());
            return true;
        }
        public override bool HandleLeft()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Left");
            this._context.TransitionTo(new Left());
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
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
