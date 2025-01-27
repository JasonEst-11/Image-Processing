using Test;
using Test.Classes;

ImageList.ClearOuptut();
var images = ImageList.GetImages();

//Set processing
ImageProcessingContext process = new(new Test.Classes.Test(225, 200));
// ImageProcessingContext process = new(new High(true,false,true));
// ImageProcessingContext process = new(new PlusMinus(25,null));
int i = 0;
foreach (string image in images)
{
    i++;
    var path = "image_in/" + image;
    ImageProcessing processing = new(path, process);
    processing.Execute(image);
    Console.WriteLine($"Created image_out/{image} - {i}/{images.Count}");
}
