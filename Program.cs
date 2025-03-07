using Test;
using Test.Classes;
using Test.Enums;
ImageList.ClearOuptut();
var images = ImageList.GetImages();

//Set processing
// ImageProcessingContext process = new(new Test.Classes.Test(null, 100));
// ImageProcessingContext process = new(new High(true,false,true));
// ImageProcessingContext process = new(new Arithmetics(2, Operations.Multiplication));
ImageProcessingContext process = new(new Invert());
int i = 0;
foreach (string image in images)
{
    i++;
    var path = "image_in/" + image;
    ImageProcessingContext processIn= new(new Test.Classes.Test(100, 100));
    ImageProcessing p = new(path, processIn);
    p.ExecuteLeftHalf(image);
    Console.WriteLine($"Created {i}/{images.Count} - image_out/{image} ");
}
