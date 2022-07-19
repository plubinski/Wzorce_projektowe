namespace Project
{
    abstract class Decorator : Vehicle
    {
        protected Vehicle _component;

        public Decorator(Vehicle component)
        {
            this._component = component;
        }
        public override State GetState()
        {
            return _component.GetState();
        }

        public void SetComponent(Vehicle component)
        {
            this._component = component;
        }

        public override bool GoForward()
        {
            if (this._component != null)
            {
                return this._component.GoForward();

            }
            return false;
        }
        public override bool GoBackward()
        {
            if (this._component != null)
            {
                return this._component.GoBackward();

            }
            return false;
        }
        public override bool GoLeft()
        {
            if (this._component != null)
            {
                return this._component.GoLeft();

            }
            return false;
        }
        public override bool GoRight()
        {
            if (this._component != null)
            {
                return this._component.GoRight();
            }
            return false;
        }
        public override bool GoRightForward()
        {
            if (this._component != null)
            {
                return this._component.GoRightForward();
            }
            return false;
        }
        public override bool GoRightBackward()
        {
            if (this._component != null)
            {
                return this._component.GoRightBackward();
            }
            return false;
        }
        public override bool GoLeftForward()
        {
            if (this._component != null)
            {
                return this._component.GoLeftForward();
            }
            return false;
        }
        public override bool GoLeftBackward()
        {
            if (this._component != null)
            {
                return this._component.GoLeftBackward();
            }
            return false;
        }
    }
}
