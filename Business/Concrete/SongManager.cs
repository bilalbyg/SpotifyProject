using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SongManager : ISongService
    {
        ISongDal _songDal;

        public SongManager(ISongDal songDal)
        {
            _songDal = songDal;
        }

        public List<Song> GetAll()
        {
            return _songDal.GetAll();
        }

        public List<Song> GetAllByCategoryId(int id)
        {
            return _songDal.GetAll(s=>s.CategoryId==id);
        }

        public List<Song> GetAllByArtistId(int id)
        {
            return _songDal.GetAll(s=>s.ArtistId==id);
        }

        public List<SongDetailDto> GetSongDetails()
        {
            return _songDal.GetSongDetails();
        }
    }
}
