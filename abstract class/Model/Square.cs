using System;
namespace abstract_class.Model

{
    class Square:Figure
    {
        private int _side;
        public int Side
        {
            get { return _side ;}


            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                   
                    Console.WriteLine("input is not correct");
                }

                
            }

        }

        public override void CalcArea()
        {
            int s = Side * Side;
            Console.WriteLine(s);
        }

        public Square(int side)
        {
            Side = side;

        }
    }
}
