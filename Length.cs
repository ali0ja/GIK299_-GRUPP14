using System;

namespace project
{
    public class Length
    {
        public void GetVal()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Choose from these to convert from:");
            Console.WriteLine("1) Meter ");
            Console.WriteLine("2) Centimeter");
            Console.WriteLine("3) Foot");
            Console.WriteLine("4) Tum ");
            Console.WriteLine("5) Yards");
            double Cho;
            while (!double.TryParse(Console.ReadLine(), out Cho) || Cho > 5 || Cho < 1)
            {
                Console.WriteLine("Invalid number, try again.");
            }

            Console.WriteLine("Choose from these to convert to:");
            Console.WriteLine("1) Meter ");
            Console.WriteLine("2) Centimeter");
            Console.WriteLine("3) Foot");
            Console.WriteLine("4) Tum ");
            Console.WriteLine("5) Yards");
            double omv;
            while (!double.TryParse(Console.ReadLine(), out omv) || omv > 5 || omv < 1)
            {
                Console.WriteLine("Invalid number, try again.");
            }

            if (Cho == 1 && omv == 2)
            {
                Console.WriteLine("Input to convert meter! ");
                double met;
                while (!double.TryParse(Console.ReadLine(), out met))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double cent = met * 100d;
                Console.WriteLine("{0} meter are {1:0.00} centimeter.", met, cent);
                Console.ReadLine();
            }
            else if (Cho == 1 && omv == 3)
            {
                Console.WriteLine("Input to convert meter!");
                double met;

                while (!double.TryParse(Console.ReadLine(), out met))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double fo = met / 3.2808;
                Console.WriteLine("{0} meter are {1:0.00} fot.", met, fo);
                Console.ReadLine();

            }
            else if (Cho == 1 && omv == 4)
            {
                Console.WriteLine("Input to convert meter!");
                double met;
                while (!double.TryParse(Console.ReadLine(), out met))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double tum = met / 39.37;
                Console.WriteLine("{0} meter are {1:0.00} tum.", met, tum);
                Console.ReadLine();

            }
            else if (Cho == 1 && omv == 5)
            {
                Console.WriteLine("Input to convert meter!");
                double met;
                while (!double.TryParse(Console.ReadLine(), out met))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double yard = met * 1.0936;
                Console.WriteLine("{0} meter are {1:0.00} yard.", met, yard);
                Console.ReadLine();

            }
            else if (Cho == 2 && omv == 1)
            {
                Console.WriteLine("Input to convert centimeter!");
                double cent;

                while (!double.TryParse(Console.ReadLine(), out cent))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double met = cent / 100;
                Console.WriteLine("{0} centimeter are {1:0.00} meter.", cent, met);
                Console.ReadLine();

            }
            else if (Cho == 2 && omv == 3)
            {
                Console.WriteLine("Input to convert centimeter!");
                double cent;
                while (!double.TryParse(Console.ReadLine(), out cent))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double fot = cent * 0.032808;
                Console.WriteLine("{0} centimeter are {1:0.00} fot.", cent, fot);
                Console.ReadLine();

            }
            else if (Cho == 2 && omv == 4)
            {
                Console.WriteLine("Input to convert centimeter!");
                double cent;
                while (!double.TryParse(Console.ReadLine(), out cent))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double tum = cent * 0.3937;
                Console.WriteLine("{0} centimeter are {1:0.00} tum.", cent, tum);
                Console.ReadLine();

            }
            else if (Cho == 2 && omv == 5)
            {
                Console.WriteLine("Input to convert centimeter!");
                double cent;
                while (!double.TryParse(Console.ReadLine(), out cent))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double yard = cent * 0.010936;
                Console.WriteLine("{0} centimeter are {1:0.00} yard.", cent, yard);
                Console.ReadLine();

            }
            else if (Cho == 3 && omv == 1)
            {
                Console.WriteLine("Input to convert foot! ");
                double fot;
                while (!double.TryParse(Console.ReadLine(), out fot))
                {
                    Console.WriteLine("Invalid number, try again.");
                }
                double met = fot * 3.2808;
                Console.WriteLine("{0} fot are {1:0.00} meter .", fot, met);
                Console.ReadLine();

            }
            else if (Cho == 3 && omv == 2)
            {
                Console.WriteLine("Input to convert foot! ");
                double fot;
                while (!double.TryParse(Console.ReadLine(), out fot))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double cent = fot / 0.032808;
                Console.WriteLine("{0} fot are {1:0.00} centimeter.", fot, cent);
                Console.ReadLine();

            }
            else if (Cho == 3 && omv == 4)
            {
                Console.WriteLine("Input to convert foot! ");
                double fot;
                while (!double.TryParse(Console.ReadLine(), out fot))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double tum = fot / 12d;
                Console.WriteLine("{0} fot are {1:0.00} tum .", fot, tum);
                Console.ReadLine();

            }
            else if (Cho == 3 && omv == 5)
            {
                Console.WriteLine("Input to convert foot! ");
                double fot;
                while (!double.TryParse(Console.ReadLine(), out fot))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double yard = fot * 0.33333;
                Console.WriteLine("{0} fot are {1:0.00} yard.", fot, yard);
                Console.ReadLine();

            }
            else if (Cho == 4 && omv == 1)
            {
                Console.WriteLine("Input to convert tum! ");
                double tum;
                while (!double.TryParse(Console.ReadLine(), out tum))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double met = tum / 39.37;
                Console.WriteLine("{0} tum are {1:0.00} meter.", tum, met);
                Console.ReadLine();

            }
            else if (Cho == 4 && omv == 2)
            {
                Console.WriteLine("Input to convert tum! ");
                double tum;
                while (!double.TryParse(Console.ReadLine(), out tum))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double cent = tum / 0.3937;
                Console.WriteLine("{0} tum are {1:0.00} centimeter.", tum, cent);
                Console.ReadLine();

            }
            else if (Cho == 4 && omv == 3)
            {
                Console.WriteLine("Input to convert tum! ");
                double tum;
                while (!double.TryParse(Console.ReadLine(), out tum))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double fot = tum * 0.08333;
                Console.WriteLine("{0} tum are {1:0.00} fot.", tum, fot);
                Console.ReadLine();


            }
            else if (Cho == 4 && omv == 5)
            {
                Console.WriteLine("Input to convert tum! ");
                double tum;
                while (!double.TryParse(Console.ReadLine(), out tum))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double yard = tum * 0.027778;
                Console.WriteLine("{0} tum are {1:0.00} yard.", tum, yard);
                Console.ReadLine();

            }
            else if (Cho == 5 && omv == 1)
            {
                Console.WriteLine("Input to convert yard! ");
                double yard;
                while (!double.TryParse(Console.ReadLine(), out yard))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double met = yard / 1.0936;
                Console.WriteLine("{0} yard are {1:0.00} meter.", yard, met);
                Console.ReadLine();

            }
            else if (Cho == 5 && omv == 2)
            {
                Console.WriteLine("Input to convert yard!");
                double yard; 
                while (!double.TryParse(Console.ReadLine(), out yard))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double cent = yard / 0.010936;
                Console.WriteLine("{0} yard are {1:0.00} centimeter.", yard, cent);
                Console.ReadLine();

            }
            else if (Cho == 5 && omv == 3)
            {
                Console.WriteLine("Input to convert yard! ");
                double yard;
                while (!double.TryParse(Console.ReadLine(), out yard))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double fot = yard * 3;
                Console.WriteLine("{0} yard are {1:0.00} foot.", yard, fot);
                Console.ReadLine();

            }
            else if (Cho == 5 && omv == 4)
            {
                Console.WriteLine("Input to convert yard! ");
                double yard;
                while (!double.TryParse(Console.ReadLine(), out yard))
                {
                    Console.WriteLine("Invalid number,try again ");
                }
                double tum = yard * 36d;
                Console.WriteLine("{0} yard are {1:0.00} tum.", yard, tum);
                Console.ReadLine();
            }
            else if (Cho == 1 && omv == 1)
            {
               Console.WriteLine("Input to convert meter!"); 
               double met;
               while (!double.TryParse(Console.ReadLine(), out met))
               {
                   Console.WriteLine("Invalid number,try again ");
               }
               
               Console.WriteLine("{0} meter are {1:0.00} meter.", met, met);
            }
            else if (Cho == 2 && omv == 2)
            {
                Console.WriteLine("Input to convert centemeter!"); 
               double cent;
               while (!double.TryParse(Console.ReadLine(), out cent))
               {
                   Console.WriteLine("Invalid number,try again ");
               }
               
               Console.WriteLine("{0} meter are {1:0.00} meter.", cent, cent); 
            }
            else if (Cho == 3 && omv == 3)
            {
                Console.WriteLine("Input to convert fot!"); 
               double foot;
               while (!double.TryParse(Console.ReadLine(), out foot))
               {
                   Console.WriteLine("Invalid number,try again ");
               }
               
               Console.WriteLine("{0} foot are {1:0.00} foot.", foot, foot); 
            }
            else if (Cho == 4 && omv == 4)
            {
                Console.WriteLine("Input to convert tum!"); 
               double tum;
               while (!double.TryParse(Console.ReadLine(), out tum))
               {
                   Console.WriteLine("Invalid number,try again ");
               }
               
               Console.WriteLine("{0} tum are {1:0.00} tum.", tum, tum); 
            }
            else if (Cho == 5 && omv == 5)
            {
                Console.WriteLine("Input to convert yard!"); 
               double yard;
               while (!double.TryParse(Console.ReadLine(), out yard))
               {
                   Console.WriteLine("Invalid number,try again ");
               }
               
               Console.WriteLine("{0} yard are {1:0.00} yard.", yard, yard); 
            }
                
                

            
        }
    }
}

                
                

            
        



