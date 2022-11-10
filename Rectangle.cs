using Simple2d;
using System.Runtime.InteropServices;

public class Rectangle
{
    [DllImport("simple2d_rust.dll")]
    private static extern IntPtr create_rectangle(IntPtr window, int a, int b, int x, int y);


    IntPtr handle;
    public static IntPtr window;

    public Rectangle(Point size, Point position) 
    {
        handle = CreateRectangle(size.X, size.Y, position.X, position.Y);

    }

    private static IntPtr CreateRectangle(int a, int b, int x, int y)
    {
        return create_rectangle(window, a, b, x, y);

    }
} 