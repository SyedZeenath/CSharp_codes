using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometricShapes
{
    //class RectangleShape : InheritedShapes
    //{
    //    //VERSION 1&2: 
    //    // public void Area(float length, float breadth)
    //    //{
    //    //    Console.WriteLine("Area of Rectangle is: {0}, Perimeter is: {1}", (length * breadth), (2 * (length + breadth)) );
    //    //}
    //    //VERSION 3:
    //    public override void Area()
    //    {
    //        float length = 12, breadth = 22;
    //        Console.WriteLine("Area of Rectangle is: {0}\nPerimeter of Rectangle is: {1}\n\n", (length * breadth), (2 * (length + breadth)));
    //    }
    //}

    //VERSION 4:
    class RectangleShape : IShapeInterfaced
    {
        public void Area()
        {
            float length = 12, breadth = 22;
            Console.WriteLine("RECTANGLE:\n Area : {0}\n Perimeter : {1}\n\n", length * breadth, 2 * (length + breadth));
        }
    }
}
