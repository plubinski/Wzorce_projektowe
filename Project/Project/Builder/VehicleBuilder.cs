namespace Project
{
    public class VehicleBuilder : IBuilder
    {
        private Context _context;

        public VehicleBuilder()
        {
            this.Reset();
        }

        public void BuildEngine(string engine)
        {
            this._context.Engine = engine;
        }

        public void BuildType(string type)
        {
            this._context.Type = type;
        }

        public void BuildWheels(int wheel)
        {
            this._context.Wheels = wheel;
            this._context.CurrentWheelStatus = new char[wheel];

            for (int i = 0; i < wheel; i++)
            {
                this._context.CurrentWheelStatus[i] = 'O';
            }
        }

        public void Reset()
        {
            _context = new Context(new Idle());
        }

        public Context GetProduct()
        {
            Context context = this._context;

            this.Reset();

            return context;
        }
    }
}
