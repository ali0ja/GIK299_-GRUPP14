using System;
namespace project
{
    public class AreaVol
    {

        public int Choice;
        public void GetChar()
        {
            Console.Clear();

            bool menuAreaVol = true;
            Choice = 0;
            while (menuAreaVol)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("********************************");
                Console.WriteLine("Choose from these options: ");
                Console.WriteLine("1) Circle area");
                Console.WriteLine("2) Rectangle area");
                Console.WriteLine("3) Traingle area");
                Console.WriteLine("4) Sphere area/volume");
                Console.WriteLine("5) Cube volume");
                Console.WriteLine("6) Pyramid volume");
                Console.WriteLine("7) Back to main menu");
                Console.WriteLine("********************************");
                Console.WriteLine();

                while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 7 || Choice < 1)
                {
                    Console.WriteLine("Invaild number, try again");
                }
                switch (Choice)
                {
                    case 1:
                        CirArea();
                        break;
                    case 2:
                        RecArea();
                        break;
                    case 3:
                        TriArea();
                        break;
                    case 4:
                        SfäArea();
                        break;
                    case 5:
                        KubVolym();
                        break;
                    case 6:
                        PyrVolym();
                        break;
                    case 7:
                        menuAreaVol = false;
                        break;
                }
            }
        }

        public void CirArea()
        {
            double pi = 3.14;
            Console.WriteLine("Please enter the radius of the circle :");

            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double cirarea = pi * Math.Sqrt(radius);
            Console.WriteLine("The area of the circle is : {0:0.00}", cirarea);
        }
        public void RecArea()
        {

            Console.WriteLine("Please enter the length of the rectangle: ");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the width of the rectangle: ");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double recarea = length * width;
            Console.WriteLine("The area of the rectangle is : {0:0.00}", recarea);
        }
        public void CylArea()
        {

            double pi = 3.14;
            Console.WriteLine("Please enter the radius of cylinder: ");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the height of the cylinder: ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double cylarea = 2 * pi * radius * height + 2 * pi * Math.Sqrt(radius);
            Console.WriteLine("The area of the cylinder is : {0:0.00}", cylarea);
        }
        public void TriArea()
        {
            Console.Write("Enter the Value of basen : ");
            double bas;
            while (!double.TryParse(Console.ReadLine(), out bas))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.Write("Enter the Value of height : ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Traingle = (height * bas) / 2;
            Console.WriteLine("\n\nThe Area of Triangle is: {0:0.00}", Traingle);
        }
        public void KubVolym()
        {
            Console.WriteLine("Please enter the width of the kub :");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the height of the kub:");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the length of the kub:");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double kubvolym = length * width * height;
            Console.WriteLine("kubvolym are : {0:0.00}", kubvolym);
        }
        public void PyrVolym()
        {
            Console.WriteLine("Please enter the width of the pyramid :");
            double width;
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the height of the  pyramid:");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            Console.WriteLine("Please enter the length of the pyramid:");
            double length;
            while (!double.TryParse(Console.ReadLine(), out length))
            {
                Console.WriteLine("Invalid number,try again ");
            }

            double slant1 = Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(height, 2));

            double slant2 = Math.Sqrt(Math.Pow(length / 2, 2) + Math.Pow(height, 2));

            double pyrvol = (length * width) + (length * slant1) + (width * slant2);
            Console.WriteLine(" PyramidArea are: {0:0.00}", pyrvol);
        }
        public void SfäArea()
        {
            double pi = 3.14;
            Console.WriteLine("Please enter the radius of the Sphere:");
            double radius;
            while (!double.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Invalid number,try again ");
            }
            double Spherearea = 4 * pi * Math.Sqrt(radius);
            double Spherevolym = 4 * pi * (radius * radius * radius / 3);

            Console.WriteLine(" Spherearea are {0:0.00}:", Spherearea);
            Console.WriteLine(" SphereVolym are {0:0.00}:", Spherevolym);
        }
    }
}


