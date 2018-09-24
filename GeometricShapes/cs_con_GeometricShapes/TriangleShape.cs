using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometricShapes
{
    //class TriangleShape : InheritedShapes
    //{
    //    //VERSION 1&2:
    //    //public void Area(float _base, float height, float side1, float side2)
    //    //{
    //    //    Console.WriteLine("Area of Triangle is: {0}, Perimeter is: {1}", ((_base * height) / 2), (_base + side1 + side2));
    //    //}
    //  
    //     //VERSION 3:
    //    public override void Area(params float[] values)
    //    {
    //        float _base = 5, height = 13, side1 = 12, side2 = 10;
    //        Console.WriteLine("Area of Triangle is: {0}\nPerimeter of Triangle is: {1}\n\n", ((_base * height) / 2), (_base + side1 + side2));
    //    }
    //}

    //VERSION 4:
    class TriangleShape : IShapeInterfaced
    {
        
        public  void Area()
        {
            float _base = 5, height = 13, side1 = 12, side2 = 10;
            Console.WriteLine("TRIANGLE:\n Area : {0}\n Perimeter : {1}\n\n", _base * height / 2, _base + side1 + side2);
        }
    }
}
