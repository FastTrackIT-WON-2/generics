using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Shape : IComparable<Shape>
    {
        public int CompareTo(Shape other)
        {
            throw new NotImplementedException();
        }
    }

    public class Rectangle : Shape, IComparable<Rectangle>
    {
        public int CompareTo(Rectangle other)
        {
            throw new NotImplementedException();
        }
    }
}
