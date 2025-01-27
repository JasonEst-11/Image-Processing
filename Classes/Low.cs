using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;
namespace Test.Classes;

public class Low : IProcessingStrategy
{
    private readonly bool Red = false;
    private readonly bool Green = false;
    private readonly bool Blue = false;
    public Low(bool r, bool g, bool b)
    {
        Red = r;
        Green = g;
        Blue = b;
    }
    public void Process(ref Rgba32 pixel)
    {
        pixel.R = Red ? (byte)0 : pixel.R;
        pixel.G = Green ? (byte)0 : pixel.G;
        pixel.B = Blue ? (byte)0 : pixel.B;
    }
}
