using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Models;

internal class Song
{
    private string[] tones = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("artist")]
    public string? artist { get; set; }
    [JsonPropertyName("song")]
    public string? title { get; set; }
    [JsonPropertyName("genre")]
    public string? genre { get; set; }
    [JsonPropertyName("duration_ms")]
    public int? duration { get; set; }
    [JsonPropertyName("key")]
    public int key { get; set; }
    public string tone
    {
        get
        {
            return tones[key];
        }
    }


    public void SongDetails()
    {
        Console.WriteLine($"Artist: {artist}");
        Console.WriteLine($"Song: {title}");
        Console.WriteLine($"Duration (ms): {duration}");
        Console.WriteLine($"Genre: {genre}");
        Console.WriteLine($"Key: {tone}");

    }
}
