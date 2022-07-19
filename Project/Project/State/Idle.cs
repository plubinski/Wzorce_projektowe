namespace Project
{
    class Idle : State
    {
        Singleton _singleton;

        public Idle()
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To Right");
            this._context.TransitionTo(new Right());
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
            _singleton.SaveLogToFile($"{_context.GetType().Name}: Change To LeftBackward");
            this._context.TransitionTo(new LeftBackward());
            return true;
        }
    }
}
