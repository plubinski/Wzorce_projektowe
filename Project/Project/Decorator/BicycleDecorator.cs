namespace Project
{
    class BicycleDecorator : Decorator
    {
        public BicycleDecorator(Context context) : base(context)
        {
            this.Engine = context.Engine;
            this.CurrentWheelStatus = context.CurrentWheelStatus;
            this.Wheels = context.Wheels;
            this.Type = context.Type;
        }

        public override void TransitionTo(State state)
        {

        }

        public override bool GoForward()
        {
            var isStateChanged = base.GoForward();
            if (isStateChanged)
            {

                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O'};
                        return true;
                    case "Forward":
                        base.CurrentWheelStatus = new char[] { 'O', 'F' };
                        return true;
                    case "LeftForward":
                        base.CurrentWheelStatus = new char[] {'L', 'F'};
                        return true;
                    case "RightForward":
                        base.CurrentWheelStatus = new char[] {'R', 'F'};
                        return true;

                }
            }

            return false;
        }
        public override bool GoBackward()
        {
            var isStateChanged = base.GoBackward();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O'};
                        return true;
                    case "Backward":
                        base.CurrentWheelStatus = new char[] { 'O', 'B' };
                        return true;
                    case "LeftBackward":
                        base.CurrentWheelStatus = new char[] { 'L', 'B'};
                        return true;
                    case "RightBackward":
                        base.CurrentWheelStatus = new char[] { 'R', 'B'};
                        return true;

                }
            }
            return false;
        }
        public override bool GoLeft()
        {
            var isStateChanged = base.GoLeft();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O' };
                        return true;
                    case "Left":
                        base.CurrentWheelStatus = new char[] { 'L', 'O'};
                        return true;
                    case "LeftForward":
                        base.CurrentWheelStatus = new char[] { 'L', 'F'};
                        return true;
                    case "RightBackward":
                        base.CurrentWheelStatus = new char[] { 'R', 'B' };
                        return true;

                }
            }
            return false;
        }
        public override bool GoRight()
        {
            var isStateChanged = base.GoRight();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O' };
                        return true;
                    case "Right":
                        base.CurrentWheelStatus = new char[] { 'R', 'O' };
                        return true;
                    case "LeftBackward":
                        base.CurrentWheelStatus = new char[] { 'L', 'B'};
                        return true;
                    case "RightForward":
                        base.CurrentWheelStatus = new char[] { 'R', 'F'};
                        return true;

                }
            }
            return false;
        }
        public override bool GoLeftBackward()
        {
            var isStateChanged = base.GoLeftBackward();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O' };
                        return true;
                    case "Left":
                        base.CurrentWheelStatus = new char[] { 'L', 'O'};
                        return true;
                    case "LeftBackward":
                        base.CurrentWheelStatus = new char[] { 'L', 'B' };
                        return true;
                    case "Backward":
                        base.CurrentWheelStatus = new char[] { 'O', 'B' };
                        return true;

                }
            }
            return false;
        }
        public override bool GoLeftForward()
        {
            var isStateChanged = base.GoLeftForward();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O' };
                        return true;
                    case "Forward":
                        base.CurrentWheelStatus = new char[] { 'O', 'F' };
                        return true;
                    case "Left":
                        base.CurrentWheelStatus = new char[] { 'L', 'O' };
                        return true;
                    case "LeftForward":
                        base.CurrentWheelStatus = new char[] { 'L', 'F' };
                        return true;

                }
            }
            return false;
        }
        public override bool GoRightBackward()
        {
            var isStateChanged = base.GoRightBackward();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O'};
                        return true;
                    case "Backward":
                        base.CurrentWheelStatus = new char[] { 'O', 'B' };
                        return true;
                    case "Right":
                        base.CurrentWheelStatus = new char[] { 'R', 'O'};
                        return true;
                    case "RightBackward":
                        base.CurrentWheelStatus = new char[] { 'R', 'B' };
                        return true;

                }
            }
            return false;
        }
        public override bool GoRightForward()
        {
            var isStateChanged = base.GoRightForward();
            if (isStateChanged)
            {
                switch (base._component.GetState().GetType().Name)
                {
                    case "Idle":
                        base.CurrentWheelStatus = new char[] { 'O', 'O'};
                        return true;
                    case "Right":
                        base.CurrentWheelStatus = new char[] { 'R', 'O'};
                        return true;
                    case "Forward":
                        base.CurrentWheelStatus = new char[] { 'O', 'F'};
                        return true;
                    case "RightForward":
                        base.CurrentWheelStatus = new char[] { 'R', 'F'};
                        return true;

                }
            }
            return false;
        }
    }
}
