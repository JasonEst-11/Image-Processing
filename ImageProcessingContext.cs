
using SixLabors.ImageSharp.PixelFormats;
using Test.Classes;
using Test.Interfaces;

public class ImageProcessingContext
{
    private IProcessingStrategy _processingStrategy;

    public ImageProcessingContext()
    {
        var defaultProcess = new Invert();
        _processingStrategy = defaultProcess;
    }

    public ImageProcessingContext(IProcessingStrategy processingStrategy)
    {
        _processingStrategy = processingStrategy;
    }

    public void SetProcess(IProcessingStrategy process)
    {
        _processingStrategy = process;
    }

    public void ExecuteProcess(ref Rgba32 pixel)
    {
        _processingStrategy.Process(ref pixel);
    }
}