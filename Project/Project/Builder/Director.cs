namespace Project
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildVehicle()
        {
            this._builder.BuildWheels(2);
            this._builder.BuildType("Bicycle");
        }
        public void BuildCar()
        {
            this._builder.BuildWheels(4);
            this._builder.BuildEngine("Benzine");
            this._builder.BuildType("Car");
        }
        public void BuildTir()
        {
            this._builder.BuildWheels(8);
            this._builder.BuildEngine("Diesel");
            this._builder.BuildType("Tir");
        }

    }
}
