
using System.Runtime.InteropServices;

namespace Simple2d 
{
    internal static class NativeApi
    {
        [DllImport("simple2d_rust.dll")]
        public static extern IntPtr create_rectangle(IntPtr window, int a, int b, int x, int y);

        [DllImport("simple2d_rust.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr create_window(string name, int x, int y);

        [DllImport("simple2d_rust.dll")]
        public static extern void window_run(IntPtr window);

        [DllImport("simple2d_rust.dll")]
        public static extern IntPtr subscribe_on_draw(IntPtr window, Action action);
        [DllImport("simple2d_rust.dll")]
        public static extern void unsubscribe_on_draw(IntPtr window, IntPtr action);

        [DllImport("simple2d_rust.dll")]
        public static extern void move_to(IntPtr shape, int x, int y);


    }
}
