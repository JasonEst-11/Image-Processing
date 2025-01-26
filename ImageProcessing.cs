using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Test;

public class ImageProcessing
{
    private readonly Image<Rgba32> image;

    public ImageProcessing(string imagePath)
    {
        image = Image.Load<Rgba32>(imagePath);
    }

    public void Invert(string name)
    {
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Rgba32 pixel = image[x, y];

                pixel.R = (byte)(255 - pixel.R);
                pixel.G = (byte)(255 - pixel.G);
                pixel.B = (byte)(255 - pixel.B);

                image[x, y] = pixel;
            }
        }
        image.Save("image_out/" + name);
    }

    public void PLusMinus(string name, int? plus = null, int? minus = null)
    {
        try
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Rgba32 pixel = image[x, y];
                    if (plus.HasValue)
                    {
                        pixel.R = (byte)(pixel.R + plus);
                        pixel.G = (byte)(pixel.G + plus);
                        pixel.B = (byte)(pixel.B + plus);
                        image[x, y] = pixel;
                    }
                    if (minus.HasValue)
                    {
                        pixel.R = (byte)(pixel.R - minus);
                        pixel.G = (byte)(pixel.G - minus);
                        pixel.B = (byte)(pixel.B - minus);
                        image[x, y] = pixel;
                    }
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
