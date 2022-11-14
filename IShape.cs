
using System.Drawing;

namespace Simple2d
{
    public interface IShape
    {
        void MoveTo(Point toPoint);
        Point Position { get; }
        Color Color { get; }


    }
}