using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemorySongDal : ISongDal
    {
        List<Song> _songs;
        public InMemorySongDal()
        {
            _songs = new List<Song>
            {
                new Song
                {
                    ArtistId = 1, SongId = 1, Duration = 1, SongName = "Painted Black"
                },
                new Song
                {
                    ArtistId = 2, SongId = 2, Duration = 1, SongName = "TNT"
                },
                new Song
                {
                    ArtistId = 3, SongId = 3, Duration = 1, SongName = "Monster"

                },
            };
        }
        public void Add(Song song)
        {
            _songs.Add(song);
        }

        public void Delete(Song song)
        {
            Song songToDelete =  _songs.SingleOrDefault(s=>s.SongId ==song.SongId);
            _songs.Remove(songToDelete);
        }

        public List<Song> GetAll()
        {
            return _songs;
        }

        public void Update(Song song)
        {
            Song songToUpdate = _songs.SingleOrDefault(s => s.SongId == song.SongId);
            songToUpdate.SongName = song.SongName;
            songToUpdate.CategoryId = song.CategoryId;
            songToUpdate.ArtistId = song.ArtistId;
            songToUpdate.Duration = song.Duration;
        }

        public List<Song> GetAllByCategory(int categoryId)
        {
           return _songs.Where(s => s.CategoryId == categoryId).ToList();
        }

        public List<Song> GetAll(Expression<Func<Song, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Song Get(Expression<Func<Song, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SongDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public List<SongDetailDto> GetSongDetails()
        {
            throw new NotImplementedException();
        }
    }
}
