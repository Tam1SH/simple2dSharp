
using System.Runtime.InteropServices;

namespace Simple2d
{
    public class Window : NativeObject
    {

        List<IntPtr> intPtrs = new List<IntPtr>();

        public Window(string name, Point size)
        {
            Handle = NativeObjectFactory.CreateWindow(name, size);
        }

        public void Run()
        {
            NativeApi.window_run(Handle);
        }
        public void OnDraw(Action action)
        {
            intPtrs.Add(NativeApi.subscribe_on_draw(Handle, action));
            //intPtrs.Add(lol);
            //actions.Add(action);
        }
        public void UnsubscribeAll()
        {
            intPtrs.ForEach((elem) =>
            {
                NativeApi.unsubscribe_on_draw(Handle, elem);
            });
        }

}

}

