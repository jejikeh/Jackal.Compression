using Compressor.ContentFile;

namespace Compressor;
using OpenCvSharp;

public static class JackalCompression
{
    public static void Test()
    {
        var image = new Image("1.jpg", ImreadModes.ReducedColor2);
        image.Compress(
            image.Content.Size(), 
            InterpolationFlags.Cubic,
            ImwriteFlags.JpegQuality,
            10);
        
    }
}