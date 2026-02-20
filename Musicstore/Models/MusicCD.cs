namespace Musicstore.Models;

public class MusicCD : Product
{
    public string Artist { get; set; }
    public string Label { get; set; }
    public short Released { get; set; }
    
    private List<string> tracks = new List<string>();
    public List<string> Tracks { get => tracks; set => tracks = value; }

    private List<Track> trackList = new List<Track>();
    public List<Track> TrackList { get => trackList; set => trackList = value; }

    public MusicCD(string title, double price, string artist, string label, short released, List<Track> tracks) : base(title, price)
    {
        Artist = artist;
        Label = label;
        Released = released;
        TrackList = tracks;
    }

    public MusicCD(string title, double price, string artist, short released) : base(title, price)
    {
        Artist = artist;
        Released = released;
    }

    public void AddTrack(string track)
    {
        tracks.Add(track);
    }

    public TimeSpan GetPlayingTime()
    {
        TimeSpan result = new TimeSpan();
        foreach (var track in TrackList)
        {
            result += TimeSpan.Parse(track.Length);
        }
        return result;
    }
}