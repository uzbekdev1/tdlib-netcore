using System;
using System.Threading;
using TDLib.Api;
using TDLib.NativeClient.CxxInterop;
using static TDLib.NativeClient.Native;


namespace TDLib.NativeClient
{
    public sealed class NativeClient : Client
    {
        public static ITdClientLogging Logging { get; private set; } = new CxxClientLogging();
        private IntPtr ptr;

        public NativeClient()
        {
            ptr = td_bridge_client_create();
        }

        private static TLObject FetchAndFreeObject(IntPtr objptr)
        {
            if (objptr == IntPtr.Zero) return null;
            var obj = TLObjectFactory.FetchCxxObject(objptr);
            CxxAbi.FreeCxxTLObject(objptr);
            return obj;
        }

        public override TLObject Execute(Function func)
        {
            //var objptr = td_bridge_client_execute(ptr, 114514, TLObjectFactory.CreateCxxObject(func), out var id);
            //return FetchAndFreeObject(ptr);

            TLObject obj = null;
            td_bridge_client_execute(ptr, 114514, TLObjectFactory.CreateCxxObject(func), (ptr, id) =>
            {
                if (ptr != IntPtr.Zero)
                    obj = TLObjectFactory.FetchCxxObject(ptr);
            });
            return obj;
        }

        protected override (long, TLObject) DoReceive(double timeout)
        {
            //var objptr = td_bridge_client_receive(ptr, timeout, out var id);
            //return (id, FetchAndFreeObject(objptr));
            if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(NativeClient));
            TLObject obj = null;
            long id = 0;
            td_bridge_client_receive(ptr, timeout, (ptr, id_) =>
            {
                if (ptr != IntPtr.Zero)
                {
                    obj = TLObjectFactory.FetchCxxObject(ptr);
                    id = id_;
                }
            });
            return (id, obj);
        }

        protected override void DoSend(Function func, long id)
        {
            if (ptr == IntPtr.Zero) throw new ObjectDisposedException(nameof(NativeClient));
            td_bridge_client_send(ptr, id, TLObjectFactory.CreateCxxObject(func));
        }

        private int disposed = 0;
        protected override void DisposeNativeClient()
        {
            if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
            {
                td_bridge_client_destroy(ptr);
            }
        }
    }
}