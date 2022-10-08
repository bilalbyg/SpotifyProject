using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ArtistManager : IArtistService
    {
        IArtistDal _artistDal;

        public ArtistManager(IArtistDal artistDal)
        {
            _artistDal = artistDal;
        }

        public List<Artist> GetAll()
        {
            return _artistDal.GetAll();
        }

        public Artist GetById(int artistId)
        {
            return _artistDal.Get(a => a.ArtistId == artistId);
        }
    }
}
