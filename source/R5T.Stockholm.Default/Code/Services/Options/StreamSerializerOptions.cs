using System;


namespace R5T.Stockholm.Default
{
    public class StreamSerializerOptions<T>
    {
        public bool AddByteOrderMark { get; set; }
    }


    public class StreamSerializerOptions
    {
        public const bool DefaultAddByteOrderMark = false;
    }
}
