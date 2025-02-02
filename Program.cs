﻿using Test;
using Test.Classes;
using Test.Enums;
ImageList.ClearOuptut();
var images = ImageList.GetImages();

//Set processing
// ImageProcessingContext process = new(new Test.Classes.Test(100, 100));
// ImageProcessingContext process = new(new High(true,false,true));
var imageName = "image1.jpg";
ImageProcessingContext process = new(new Arithmetics(4, Operations.Division));
ImageProcessing processing = new($"image_in/{imageName}", process);

// First process will apply normally
processing.ExecuteBottomHalf("BH.jpg");
// Second process will apply on top of the first process 
processing.ExecuteLeftHalf("LH.jpg");

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
