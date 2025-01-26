using SixLabors.ImageSharp.PixelFormats;

namespace Test.Interfaces;

public interface IProcessingStrategy
{
    void Process(ref Rgba32 pixel);
}