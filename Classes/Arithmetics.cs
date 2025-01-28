using SixLabors.ImageSharp.PixelFormats;
using Test.Enums;
using Test.Interfaces;

namespace Test.Classes;

public class Arithmetics : IProcessingStrategy
{
    private int Value { get; set; }
    private Operations _operation;

    public Arithmetics(int value, Operations operation)
    {
        Value = value;
        _operation = operation;
    }
    public void Process(ref Rgba32 pixel)
    {
        switch (_operation)
        {
            case Operations.Addition:
                pixel.R = (byte)(pixel.R + Value);
                pixel.G = (byte)(pixel.G + Value);
                pixel.B = (byte)(pixel.B + Value);
                break;
            case Operations.Subtraction:
                pixel.R = (byte)(pixel.R - Value);
                pixel.G = (byte)(pixel.G - Value);
                pixel.B = (byte)(pixel.B - Value);
                break;
            case Operations.Multiplication:
                pixel.R = (byte)(pixel.R - Value);
                pixel.G = (byte)(pixel.G - Value);
                pixel.B = (byte)(pixel.B - Value);
                break;
            case Operations.Division:
                pixel.R = (byte)(pixel.R - Value);
                pixel.G = (byte)(pixel.G - Value);
                pixel.B = (byte)(pixel.B - Value);
                break;
            default:
                break;
        }
    }
}
