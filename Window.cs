
using System.Runtime.InteropServices;

namespace Simple2d
{
    class Window
    {
        [DllImport("simple2d_rust.dll")]
        private static extern IntPtr create_window(string name, int x, int y);

        [DllImport("simple2d_rust.dll")]
        private static extern void window_run(IntPtr window);

        [DllImport("simple2d_rust.dll")]
        private static extern IntPtr subscribe_on_draw(IntPtr window, Action action);
        [DllImport("simple2d_rust.dll")]
        private static extern void unsubscribe_on_draw(IntPtr window, IntPtr action);


        IntPtr window;

        List<IntPtr> intPtrs = new List<IntPtr>();

        public Window(string name, Point size)
        {
            window = create_window(name, size.X, size.Y);
            Rectangle.window = window;
        }

        public void Run()
        {
            window_run(window);
        }
        public void OnDraw(Action action)
        {
            intPtrs.Add(subscribe_on_draw(window, action));
            //intPtrs.Add(lol);
            //actions.Add(action);
        }
        public void UnsubscribeAll()
        {
            intPtrs.ForEach((elem) =>
            {
                unsubscribe_on_draw(window, elem);
            });
        }

}

}

