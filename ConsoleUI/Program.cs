using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SongTest();

            //ArtistTest();
        }

        private static void ArtistTest()
        {
            ArtistManager artistManager = new ArtistManager(new EfArtistDal());
            foreach (var artist in artistManager.GetAll())
            {
                Console.WriteLine(artist.ArtistName);
            }
        }

        private static void SongTest()
        {
            SongManager songManager = new SongManager(new EfSongDal());

            foreach (var song in songManager.GetSongDetails())
            {
                Console.WriteLine(song.SongName + "/" + song.ArtistName);
            }
        }
    }
}
