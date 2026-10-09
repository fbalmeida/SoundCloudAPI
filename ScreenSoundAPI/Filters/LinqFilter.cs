using ScreenSoundAPI.Models;
using System.Linq;

namespace ScreenSoundAPI.Filters;

internal class LinqFilter
{
    public static void ListGenders(List<Song> songs)
    {
        var allGenres = songs.Select(genres => genres.genre).Distinct().ToList();
        foreach (var genre in allGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistByGender(List<Song> songs, string genre)
    {
        var artistByGenre = songs.Where(songs => songs.genre!.Contains(genre)).Select(song => song.artist).Distinct().ToList();
        Console.WriteLine($"Listing Artist by Genre > {genre}");
        foreach (var artist in artistByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterSongsByArtist(List<Song> songs, string artistName) 
    {
        var songByArtist = songs.Where(song => song.artist!.Equals(artistName)).ToList();
        Console.WriteLine($"Listing Songs by Artist > {artistName}");
        foreach (var song in songByArtist)
        {
            Console.WriteLine($"- {song.title}");
        }
    }

    internal static void FilterSongsToneCSharp(List<Song> songs)
    {
        var SongsinCSarp = songs
            .Where(song => song.key.Equals("C#"))
            .Select(song => song.title)
            .ToList();


        Console.WriteLine("Listing songs in C# Tone: ");
        foreach (var music in SongsinCSarp)
        {
            Console.WriteLine($"- {music}");
        }

        
    }
}
