using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_GeometricShapes
{
    //VERSION 1: OVERLOADED ETHODS
    //class AreaPerimeter
    //{
    //    public void Area(TriangleShape objTriangle)
    //    {

    //        objTriangle.Area(5, 2);
    //    }

    //    public void Area(CircleShape objCircle)
    //    {
    //        objCircle.Area(12);
    //    }

    //    public void Area(SquareShape objSquare)
    //    {
    //        objSquare.Area(14);
    //    }

    //    public void Area(RectangleShape objRectangle)
    //    {
    //        objRectangle.Area(12, 22);
    //    }
    //}


    //VERSION 2: BOXING AND UNBOXING
    //class AreaPerimeter
    //{
    //    public void Area(object obj)
    //    {
    //        if(obj is TriangleShape)
    //        {
    //            (obj as TriangleShape).Area(5, 13, 15, 16);
    //        }

    //        else if(obj is SquareShape)
    //        {
    //            (obj as SquareShape).Area(12);
    //        }

    //        else if(obj is RectangleShape)
    //        {
    //            (obj as RectangleShape).Area(12, 22);
    //        }
    //        else if(obj is CircleShape)
    //        {
    //            (obj as CircleShape).Area(12);
    //        }
    //    }
    //}

    //VERSION 3: INHERITANCE
    //class AreaPerimeter
    //{
    //    public void Area(InheritedShapes ap)
    //    {
    //        ap.Area();


    //    }
    //}

    //VERSION 4: INTERFACE
    class AreaPerimeter
    {
        public void Area(IShapeInterfaced objshape)
        {
            objshape.Area();        
    
        }
    }
}
