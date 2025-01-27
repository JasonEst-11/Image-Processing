using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;
namespace Test.Classes;

public class Test : IProcessingStrategy
{
    // private readonly bool Red = false;
    // private readonly bool Green = false;
    // private readonly bool Blue = false;
    public Test()
    {
        
    }
    public void Process(ref Rgba32 pixel)
    {

        pixel.R = pixel.R < 100 ? (byte)(pixel.R / 2) : (byte)(pixel.R * 2);
        pixel.G = pixel.G < 100 ? (byte)(pixel.G / 2) : (byte)(pixel.G * 2);
        pixel.B = pixel.B < 100 ? (byte)(pixel.B / 2) : (byte)(pixel.B * 2);
    }
}
