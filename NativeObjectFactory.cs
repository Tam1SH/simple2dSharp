namespace Simple2d
{
    internal static class NativeObjectFactory
    {
        static IntPtr window = IntPtr.Zero;

        public static IntPtr CreateWindow(string name, Point size)
        {
            window = NativeApi.create_window(name, size.X, size.Y);
            return window;
        }
        public static IntPtr CreateObject<T>(Point position, Point size) where T : IShape
        {
            return default(T) switch 
            {
                Rectangle => CreateRectangle(position, size),
                _ => throw new InvalidCastException()
            };
        }
        private static IntPtr CreateRectangle(Point position, Point size)
        {
            return NativeApi.create_rectangle(window, size.X,size.Y, position.X, position.Y);
        }

    }
}