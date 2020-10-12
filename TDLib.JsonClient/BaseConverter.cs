using TDLib.Api;

namespace TDLib.JsonClient
{
    abstract partial class BaseConverter
    {
        internal virtual bool TdJsonReadItem(ref TdJsonReader reader, TLObject obj, uint hash) => false;

        /// <remarks>
        /// Doesn't write EndObject token '}'.
        /// </remarks>
        /// <param name="writer"></param>
        /// <param name="obj"></param>
        internal abstract void TdJsonWriteUnclosedObject(TdJsonWriter writer, TLObject obj);
    }

    abstract partial class TLObjectConverter<T> : BaseConverter where T : TLObject { }
}
