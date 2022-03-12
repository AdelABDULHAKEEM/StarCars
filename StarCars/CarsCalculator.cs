using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCars
{
   public class CarsCalculator
    {
        public int ID { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public char Class { get; set; }
        
        public double GetCarWeight()
        {
            switch(Class)
            {
                case 'A':
                    return   (Width - 150) - ((Height - 100) / 4);
                case 'B':
                    return (Width - 150) - ((Height - 100) / 3);
                case 'C':
                    return (Width - 150) - ((Height - 100) / 2);
                default:
                    return 0;
                  
            }
        }
    }
}
