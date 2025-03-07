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
    ImageProcessing processing = new(path, process);
    processing.Execute(image);
    Console.WriteLine($"Created image_out/{image} - {i}/{images.Count}");
}
