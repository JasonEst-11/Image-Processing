
using SixLabors.ImageSharp.PixelFormats;
using Test.Interfaces;

namespace Test.Classes;

public class PlusMinus : IProcessingStrategy
{
    public int? Plus { get; set; }
    public int? Minus { get; set; }

    public PlusMinus(int? plus = null, int? minus = null)
    {
        Plus = plus;
        Minus = minus;
    }
    public void Process(ref Rgba32 pixel)
    {
        if (Plus.HasValue)
        {
            pixel.R = (byte)(pixel.R + Plus);
            pixel.G = (byte)(pixel.G + Plus);
            pixel.B = (byte)(pixel.B + Plus);
        }
        if (Minus.HasValue)
        {
            pixel.R = (byte)(pixel.R - Minus);
            pixel.G = (byte)(pixel.G - Minus);
            pixel.B = (byte)(pixel.B - Minus);
        }
    }
}
