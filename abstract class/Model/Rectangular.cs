using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Model
{
    class Rectangular:Figure
    {

        private int _width;
   
        public int width{
            get  {  return _width; } 
            
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {

                    Console.WriteLine("input is not correct");
                }
            }
        }


        private int _length;
        public int length 
        
       { 
            get { return _length; }




            set
            
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {

                    Console.WriteLine("input is not correct");
                }

            }
        
        
        }
        public override void CalcArea()
        {
            int s = width * length;
            Console.WriteLine(s);
        }

        public Rectangular(int width, int length)
        {
            this.width = width;
            this.length = length;
        }



    }
}
