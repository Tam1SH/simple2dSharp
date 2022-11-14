
namespace Simple2d
{
    public abstract class NativeObject
    {
        protected IntPtr Handle { get; set; }
        public NativeObject() { }
        
    }
}