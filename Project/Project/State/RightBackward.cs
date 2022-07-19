namespace Project
{
    class RightBackward : State
    {
        Singleton _singleton;

        public RightBackward()
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
            return false;
        }
        public override bool HandleRight()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Right");
            this._context.TransitionTo(new Right());
            return true;
        }
        public override bool HandleLeftForward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
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
            return false;
        }
    }
}
