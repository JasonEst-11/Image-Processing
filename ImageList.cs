namespace Test;
public static class ImageList
{
    public static List<string> GetImages()
    {
        string[] imageExtensions = [".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp"];
        string[] files = Directory.GetFiles("image_in")
                                .Where(file => imageExtensions
                                .Any(ext => file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                                .ToArray();
        List<string> filenames = [];
        foreach (string file in files)
        {
            filenames.Add(Path.GetFileName(file));
        }
        return filenames;
    }
    public static void ClearOuptut()
    {
        if (Directory.Exists("image_out"))
        {
            string[] files = Directory.GetFiles("image_out");
            foreach (string file in files)
            {
                File.Delete(file);
            }
        }
        else
        {
            Directory.CreateDirectory("./image_out");
        }
    }
}