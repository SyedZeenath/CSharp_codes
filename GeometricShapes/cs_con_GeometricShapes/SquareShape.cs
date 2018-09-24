using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometricShapes
{
    //class SquareShape: InheritedShapes
    //{
    //    //VERSION 1&2: OVERLOADED METHODS AND BOXING,UNBOXING
    //    //public void Area(int side)
    //    //{
    //    //    Console.WriteLine("Area of square is: {0}, Perimeter is: {1}", (side * side), (4 * side));
    //    //}

    //    //VERSION 3:INHERITANCE
    //    public override void Area()
    //    {
    //        float side = 12;
    //        Console.WriteLine("Area of square is: {0}\nPerimeter of square is: {1}\n\n", (side * side), (4 * side));
    //    }
    //}
    //VERSION 4: INTERFACE
    class SquareShape : IShapeInterfaced
    {
        public  void Area()
        {
            float side = 12;
            Console.WriteLine("SQUARE:\n Area : {0}\n Perimeter : {1}\n\n", side * side, 4 * side);
        }

        
    }
}
