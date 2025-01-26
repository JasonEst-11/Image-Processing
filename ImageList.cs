namespace Test;
public static class ImageList
{
    public static List<string> GetImages()
    {
        string[] files = Directory.GetFiles("image_in");
        List<string> filenames = [];
        foreach (string file in files)
        {
            filenames.Add(Path.GetFileName(file));
        }
        return filenames;
    }
    public static void ClearOuptut()
    {
        string[] files = Directory.GetFiles("image_out");
        foreach (string file in files)
        {
            File.Delete(file);
        }
    }
}