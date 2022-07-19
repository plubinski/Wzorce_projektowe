namespace Project
{
    class LeftForward : State
    {
        Singleton _singleton;

        public LeftForward()
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
            return false;
        }
        public override bool HandleRightBackward()
        {
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Idle");
            this._context.TransitionTo(new Idle());
            return true;
        }
        public override bool HandleLeftBackward()
        {
            return false;
        }
    }
}
