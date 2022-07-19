namespace Project
{
    class RightForward : State
    {
        Singleton _singleton;

        public RightForward()
        {
            _singleton = Singleton.GetInstance();
        }

        public override bool HandleForward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Forward");
            this._context.TransitionTo(new Forward());
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Right");
            this._context.TransitionTo(new Right());
            return true;
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
            return false;
        }
        public override bool HandleLeftBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
        }
    }
}
