namespace Musicstore.Models;

public class Track
{
    public string Title { get; set; }
    public string Composer { get; set; }
    public string Length { get; set; }

    public Track(string title, string length)
    {
        Title = title;
        Length = length;
    }

    public Track(string title, string composer, string length)
    {
        Title = title;
        Composer = composer;
        Length = length;
    }
}