using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;
namespace Test.Classes;

public class High : IProcessingStrategy
{
    private readonly bool Red = false;
    private readonly bool Green = false;
    private readonly bool Blue = false;
    public High(bool r, bool g, bool b)
    {
        Red = r;
        Green = g;
        Blue = b;
    }
    public void Process(ref Rgba32 pixel)
    {
        pixel.R = Red ? (byte)255 : pixel.R;
        pixel.G = Green ? (byte)255 : pixel.G;
        pixel.B = Blue ? (byte)255 : pixel.B;
    }
}
