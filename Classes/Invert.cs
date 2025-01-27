using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;

class Invert : IProcessingStrategy
{
    public void Process(ref Rgba32 pixel)
    {
        pixel.R = (byte)(255 - pixel.R);
        pixel.G = (byte)(255 - pixel.G);
        pixel.B = (byte)(255 - pixel.B);
    }
}