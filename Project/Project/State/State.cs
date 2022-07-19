namespace Project
{
    public abstract class State
    {
        protected Vehicle _context;

        public void SetContext(Vehicle context)
        {
            _context = context;
        }

        public abstract bool HandleForward();
        public abstract bool HandleBackward();
        public abstract bool HandleLeft();
        public abstract bool HandleRight();
        public abstract bool HandleLeftForward();
        public abstract bool HandleRightForward();
        public abstract bool HandleRightBackward();
        public abstract bool HandleLeftBackward();

    }
}
