using ScreenSoundAPI.Models;

namespace ScreenSoundAPI.Filters;

internal class LinqOrder
{
    public static void ShowArtistListOrder(List<Song> song)
    {
        var artistsOrdered = song.OrderBy(song => song.artist).Select(song => song.artist).Distinct().ToList();
        Console.WriteLine("Artists List (alphabetic order): ");
        foreach (var artist in artistsOrdered)
        {
            Console.WriteLine($"-{artist}");
        }

    }
}
