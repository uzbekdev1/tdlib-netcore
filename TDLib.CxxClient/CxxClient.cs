using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TDLib;
using TDLib.Api;
using TDLib.CxxClient.CxxInterop;
using static TDLib.CxxClient.Native;


namespace TDLib.CxxClient
{
    public sealed class CxxClient : Client, IDisposable
    {
        public static ITdClientLogging Logging { get; private set; } = new CxxClientLogging();
        private IntPtr ptr;

        public CxxClient()
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

        public override (long, TLObject) Receive(double timeout)
        {
            //var objptr = td_bridge_client_receive(ptr, timeout, out var id);
            //return (id, FetchAndFreeObject(objptr));
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

        public override void Send(Function func, long id)
        {
            td_bridge_client_send(ptr, id, TLObjectFactory.CreateCxxObject(func));
        }

        #region IDisposable
        ~CxxClient()
        {
            Dispose();
        }
        public void Dispose()
        {
            if (ptr != IntPtr.Zero)
                td_bridge_client_destroy(ptr);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
