﻿using Test;
using Test.Classes;

ImageList.ClearOuptut();
var images = ImageList.GetImages();

//Set processing
ImageProcessingContext process = new(new High(true, true, true));
foreach (string image in images)
{
    var path = "image_in/" + image;
    ImageProcessing processing = new(path, process);
    processing.Execute(image);
}
