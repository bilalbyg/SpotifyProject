using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Artist GetById(int artistId)
        {
            return _artistDal.Get(a => a.ArtistId == artistId);
        }

        private IResult CheckIfArtistNameExists(string artistName)
        {
            var result = _artistDal.GetAll(a => a.ArtistName == artistName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ArtistNameAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<List<Artist>> GetAll()
        {
            return new SuccessDataResult<List<Artist>>(_artistDal.GetAll(), Messages.ArtistsListed);
        }

        public IResult Add(Artist artist)
        {
            IResult result = BusinessRules.Run(CheckIfArtistNameExists(artist.ArtistName));
            
            if(result != null)
            {
                return result;
            }
            
            _artistDal.Add(artist);
            return new SuccessResult(Messages.ArtistAdded);
        }
    }
}
