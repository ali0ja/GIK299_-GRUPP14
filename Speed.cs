using System;
namespace project
{
    public class Speed
    {
        public double speed;


        public void Getspeed(){
             Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Input the distance you want to calculate(km):");
            double distance;
             while (!double.TryParse(Console.ReadLine(), out distance))
                {
                 Console.WriteLine("Invalid number,try again ");
                }
                Console.WriteLine("Input time (min) : ");
                 double time;
             while (!double.TryParse(Console.ReadLine(), out time))
                {
                 Console.WriteLine("Invalid number,try again ");
                }
                double speed= distance /time;
                Console.WriteLine( "Speed are {0:0.00} (km/min)." ,speed);
                

        }
    }
}