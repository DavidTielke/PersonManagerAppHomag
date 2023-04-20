namespace ConsleClient;

internal class FileLoader
{
    public string[] LoadLines(string path)
    {
        return File.ReadAllLines(path);
    }
}