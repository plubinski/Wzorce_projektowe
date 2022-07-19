namespace Project
{
    public interface IBuilder
    {
        void BuildType(string type);
        void BuildWheels(int wheel);
        void BuildEngine(string engine);
    }
}
