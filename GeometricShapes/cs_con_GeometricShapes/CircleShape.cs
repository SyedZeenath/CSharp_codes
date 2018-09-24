using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cs_con_GeometricShapes
{
    //class CircleShape: InheritedShapes
    //{
    //    //VERSION 1&2:
    //    //public void Area(double radius)
    //    //{
    //    //    Console.WriteLine("Area of circle is: {0}, Perimeter is: {1}", (3.14 * radius * radius), (4 * 3.14 * radius));
    //    //}

    //    //VERSION 3:
    //    public override void Area(params float[] values)
    //    {
    //        float radius = 20;
    //        Console.WriteLine("Area of circle is: {0}\nPerimeter of circle is: {1}\n\n", (3.14 * radius * radius), (4 * 3.14 * radius));
    //    }
    //}

    //VERSION 4:
    class CircleShape : IShapeInterfaced
    {
        public void Area()
        {
            float radius = 20;
            Console.WriteLine("CIRCLE:\n Area : {0}\n Perimeter : {1}\n\n", 3.14 * radius * radius, 4 * 3.14 * radius);
        }
    }
}
