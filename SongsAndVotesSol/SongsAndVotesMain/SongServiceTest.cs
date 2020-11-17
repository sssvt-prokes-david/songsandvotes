using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsAndVotesMain
{
    class SongServiceTest
    {


        public void TestLoadSongMetadata(string Path)
        {
            string pathToSong = Path;
            Song song = newSong(pathToSong);
            SongServiceTest songService = new SongService();
            songService.TestLoadSongMetadata(song);
            Console.WriteLine();

            Console.WriteLine(
                "{0}"
                + "Title:                 {1}{0}"
                + "Artist:                {2}{0}"
                + "Album:                 {3}{0}"
                + "Year:                  {4}{0}"
                + "Track #:               {5}{0}"
                + "{0}{0}",
                Environment.NewLine,
                song.Title,
                song.Artist,
                song.Album,
                song.Year,
                song.TrackNo
                );


        }



    }
}
