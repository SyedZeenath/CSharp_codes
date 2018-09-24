using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareShape objSquare = new SquareShape();
            RectangleShape objRectangle = new RectangleShape();
            CircleShape objCircle = new CircleShape();
            TriangleShape objTriangle = new TriangleShape();

            AreaPerimeter objAreaPerimeter = new AreaPerimeter();

            objAreaPerimeter.Area(objSquare);
            objAreaPerimeter.Area(objRectangle);
            objAreaPerimeter.Area(objCircle);
            objAreaPerimeter.Area(objTriangle);

        }
    }
}
