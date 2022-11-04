using OpenCvSharp;

namespace Compressor.ContentFile;

public class Image
{
    public Mat Content { get; private set; }
    private string FilePath { get; set; }

    public Image(string fileName, ImreadModes flags)
    {
        Content = new Mat(fileName, flags);
        FilePath = fileName;
    }

    public void Compress(Size newSize, InterpolationFlags resizeFlags, ImwriteFlags compressionFlags, int quality)
    {
        Cv2.Resize(Content, Content, newSize,2D,2D,resizeFlags);
        Cv2.ImWrite(FilePath, Content, new ImageEncodingParam(compressionFlags, quality));
    }
}