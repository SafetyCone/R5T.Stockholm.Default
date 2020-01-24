using System;


namespace R5T.Stockholm.Default
{
    public class DefaultStreamOperatorOptions<T> : IStreamSerializerOptions<T>
    {
        public bool AddByteOrderMark { get; set; } = DefaultStreamOperatorOptions.DefaultAddByteOrderMark;
    }


    public class DefaultStreamOperatorOptions
    {
        public const bool DefaultAddByteOrderMark = true;
    }
}
