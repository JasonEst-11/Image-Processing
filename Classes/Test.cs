using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;
namespace Test.Classes;

public class Test : IProcessingStrategy
{
    private int? Big;
    private int? Small;
    public Test(int? big = null, int? small = null)
    {
        Big = big;
        Small = small;
    }
    public void Process(ref Rgba32 pixel)
    {
        if (Big.HasValue)
        {
            pixel.R = pixel.R < Big ? (byte)(pixel.R / 2) : (byte)(pixel.R * 2);
            pixel.G = pixel.G < Big ? (byte)(pixel.G / 2) : (byte)(pixel.G * 2);
            pixel.B = pixel.B < Big ? (byte)(pixel.B / 2) : (byte)(pixel.B * 2);
            pixel.A = 255;
        }
        else
        {
            pixel.R = pixel.R > Small ? (byte)(pixel.R / 2) : (byte)(pixel.R * 2);
            pixel.G = pixel.G > Small ? (byte)(pixel.G / 2) : (byte)(pixel.G * 2);
            pixel.B = pixel.B > Small ? (byte)(pixel.B / 2) : (byte)(pixel.B * 2);
        }
    }
}
