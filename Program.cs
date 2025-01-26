using Test;

ImageList.ClearOuptut();
var images = ImageList.GetImages();
foreach (string image in images)
{
    ImageProcessing processing = new ImageProcessing("image_in/" + image);
    processing.Execute(image);
}
