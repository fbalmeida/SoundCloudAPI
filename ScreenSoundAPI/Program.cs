using ScreenSoundAPI.Models;
using System.Text.Json;
using ScreenSoundAPI.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Song>>(response)!;
        //Console.WriteLine("Total Songs: " + songs.Count);
        //songs[0].SongDetails();
        //songs[4].SongDetails();
        //songs[113].SongDetails();

        //LinqFilter.ListGenders(songs);
        //LinqOrder.ShowArtistListOrder(songs);
        //LinqFilter.FilterArtistByGender(songs, "rock");
        //LinqFilter.FilterSongsByArtist(songs, "Justin Bieber");
        //LinqFilter.FilterSongsToneCSharp(songs);
        
        var danFavoriteSongs = new FavoriteSongs("Dan");
        danFavoriteSongs.AddSongs(songs[4]);
        danFavoriteSongs.AddSongs(songs[6]);
        danFavoriteSongs.AddSongs(songs[67]);
        danFavoriteSongs.AddSongs(songs[1996]);
        danFavoriteSongs.AddSongs(songs[377]);

        danFavoriteSongs.ShowList();
        danFavoriteSongs.SaveFile();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}