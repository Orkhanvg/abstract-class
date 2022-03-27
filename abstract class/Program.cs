using abstract_class.Model;
using System;

namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square\n"+
                              "2.Rectangular\n"+
                              "0.Quit");

            Console.WriteLine("Please enter the one option");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1: /* İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
                         */


                    Console.WriteLine( "please enter the size of side");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(side);
                    side = square.Side;
                    square.CalcArea();
                    break;

                case 2:
                   /* İstifadəçi 2 yazıb enter-ə click - ləsə Rectangular -in CalcArea methodu işə düşməlidir.
                    */

                   Console.WriteLine( "please enter the size of width and length");
                    int width = Convert.ToInt32(Console.ReadLine());
                    int length = Convert.ToInt32(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(width,length);
                    width = rectangular.width;
                    length = rectangular.length;
                    rectangular.CalcArea();
                    break;

                case 3:

                    return;







            }
        }
    }
}
