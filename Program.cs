using Test;

ImageList.ClearOuptut();
var images = ImageList.GetImages();

//Set processing
ImageProcessingContext process = new(new PlusMinus(null,70));
foreach (string image in images)
{
    var path = "image_in/" + image;
    ImageProcessing processing = new(path, process);
    processing.Execute(image);
}
