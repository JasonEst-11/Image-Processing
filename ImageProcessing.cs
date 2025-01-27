using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Test;

public class ImageProcessing
{
    private readonly Image<Rgba32> image;
    private readonly ImageProcessingContext _processContext;
    public ImageProcessing(string imagePath, ImageProcessingContext processContext)
    {
        image = Image.Load<Rgba32>(imagePath);
        _processContext = processContext;
    }

    public void Execute(string name)
    {
        try
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Rgba32 pixel = image[x, y];

                    _processContext.ExecuteProcess(ref pixel);

                    image[x, y] = pixel;
                }
            }
            image.Save("image_out/" + name);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
