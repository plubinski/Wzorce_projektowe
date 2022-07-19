using System;

namespace Project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new VehicleBuilder();

            director.Builder = builder;
            
            Console.WriteLine("1 - Bicycle\n2 - Car\n3 - Bus\n");
            Console.Write("Choose your vehicle: ");
            var choose =  Console.ReadLine();

            switch (choose) {
                case "1":

                    director.BuildVehicle();

                    var bicycle = builder.GetProduct();

                    Console.WriteLine("\n");

                    BicycleDecorator bicycleDecorator = new BicycleDecorator(bicycle);

                    Ride(bicycleDecorator, "Bicycle");

                    break;
                case "2":

                    director.BuildCar();

                    var car = builder.GetProduct();

                    Console.WriteLine("\n");

                    CarDecorator carDecorator = new CarDecorator(car);

                    Ride(carDecorator, "Car");

                    break;
                case "3":

                    director.BuildTir();

                    var bus = builder.GetProduct();

                    Console.WriteLine("\n");

                    BusDecorator busDecorator = new BusDecorator(bus);

                    Ride(busDecorator, "Bus");

                    break;
                default:
                    Console.WriteLine("This is not an option!");
                    break;
                
            }
           
        }

        static void Ride(Vehicle v, string name)
        {

            string choose = "-1";
            Console.Clear();
            while (choose != "0")
            {

                Console.WriteLine(" ========== " + name + " ========== ");
                Console.WriteLine("\nL - Left\nR - Right\nF - Forward\nB - Backward\nO - Idle\n");
                Console.WriteLine("Controls");
                Console.WriteLine((v.GetState().GetType().Name == "LeftForward" ? "(1)" : " 1 ") +  " - "+ (v.GetState().GetType().Name == "Forward" ? "(2)" : " 2 ") + " - " + (v.GetState().GetType().Name == "RightForward" ? "(3)" : " 3 ")+ "\n" +
                                  (v.GetState().GetType().Name == "Left" ? "(4)" : " 4 ") + " - " + (v.GetState().GetType().Name == "Idle" ? "( )" : "   ") + " - " + (v.GetState().GetType().Name == "Right" ? "(6)" : " 6 ") + "\n" +
                                  (v.GetState().GetType().Name == "LeftBackward" ? "(7)" : " 7 ") + " - " + (v.GetState().GetType().Name == "Backward" ? "(8)" : " 8 ") + " - " + (v.GetState().GetType().Name == "RightBackward" ? "(9)" : " 9 ") + "\n");
                Console.WriteLine(v.DrawVehicle());
                choose = Console.ReadLine();
                Console.Clear();
                switch (choose)
                {
                    case "1":
                        v.GoLeftForward();
                        break;
                    case "2":
                        v.GoForward();
                        break;
                    case "3":
                        v.GoRightForward();
                        break;
                    case "4":
                        v.GoLeft();
                        break;
                    case "6":
                        v.GoRight();
                        break;
                    case "7":
                        v.GoLeftBackward();
                        break;
                    case "8":
                        v.GoBackward();
                        break;
                    case "9":
                        v.GoRightBackward();
                        break;
                }
            }
        }
    }
}
