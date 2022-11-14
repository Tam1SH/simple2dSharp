using Simple2d;
using System.Drawing;
using System.Runtime.InteropServices;
using Point = Simple2d.Point;

public class Rectangle : NativeObject, IShape
{
    public Rectangle(Point size, Point position) 
    {
        this.position = position;

        //стоило бы это скрыть.
        Handle = NativeObjectFactory.CreateRectangle(size, position);
    }

    public Point Position => position;
    public System.Drawing.Color Color => color;

    public void MoveTo(Point toPoint)
    {
        NativeApi.move_to(Handle, toPoint.X, toPoint.Y);
    }

    private Point position;
    private Color color;

} 