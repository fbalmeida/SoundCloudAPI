using System.Text.Json;

namespace ScreenSoundAPI.Models;

internal class FavoriteSongs
{
    public string Name { get; set; }
    public List<Song> FavoriteSongList { get; }

    public FavoriteSongs(string name)
    {
        Name = name;
        FavoriteSongList = new List<Song>();
    }

    public void AddSongs(Song song)
    {
        FavoriteSongList.Add(song);
    }

    public void ShowList()
    {
        Console.WriteLine($"Song List {Name}:");
        foreach(Song song in FavoriteSongList)
        {
            Console.WriteLine($"* {song.artist} - {song.title}");
        }

    }

    public void SaveFile() 
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = FavoriteSongList
        });
        string FileName = $"favorite-songs-{Name}.json";
        File.WriteAllText(FileName, json);
        Console.WriteLine($"File created successfully! {Path.GetFullPath(FileName)}");

    }
}
