namespace ScreenToGif.ImageUtil.Psd
{
    internal interface IPsdContent
    {
        /// <summary>
        /// The total length of the byte array.
        /// </summary>
        long Length { get; }

        byte[] Content { get; }
    }
}