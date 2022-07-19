namespace Project
{
    public abstract class Vehicle
    {
        private string _type;
        private int _wheels;
        private string _engine;
        private char[] _currentWheelStatus;



        public abstract State GetState();
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Wheels
        {
            get { return _wheels; }
            set { _wheels = value; }
        }
        public string Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public char[] CurrentWheelStatus
        {
            get { return _currentWheelStatus; }
            set { _currentWheelStatus = value; }
        }

        public abstract void TransitionTo(State state);

        public string DrawVehicle()
        {
            if (_wheels == 2)
            {
                return $"\t\t{_currentWheelStatus[0]}\n" +
                       $"\t\t|\n" +
                       $"\t\t{_currentWheelStatus[1]}\n";
            }

            string draw = "";
            for (int i = 0; i < _wheels; i++)
            {
                draw += i % 2 == 0 ? $"\t\t{_currentWheelStatus[i]}" : $" - {_currentWheelStatus[i]}\n\n";
            }

            return draw;
        }

        public abstract bool GoForward();
        public abstract bool GoBackward();
        public abstract bool GoLeft();
        public abstract bool GoRight();
        public abstract bool GoLeftBackward();
        public abstract bool GoLeftForward();
        public abstract bool GoRightForward();
        public abstract bool GoRightBackward();

    }
}
