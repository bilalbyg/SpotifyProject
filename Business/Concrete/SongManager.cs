using Business.Abstract;
using Business.CCC;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        public IDataResult<List<Song>> GetAll()
        {
            if(DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Song>>(Messages.MaintenanceTime);
            }

                return new SuccessDataResult<List<Song>>(_songDal.GetAll(), Messages.SongsListed);

            
        }

        public IDataResult<List<Song>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Song>>(_songDal.GetAll(s => s.CategoryId == id));
        }

        public IDataResult<List<Song>> GetAllByArtistId(int id)
        {
            return new SuccessDataResult<List<Song>>(_songDal.GetAll(s => s.ArtistId == id));
        }

        public IDataResult<List<SongDetailDto>> GetSongDetails()
            
        {
            return new SuccessDataResult<List<SongDetailDto>>(_songDal.GetSongDetails());
        }

        //[ValidationAspect(typeof(SongValidator))]
        public IResult Add(Song song)
        {
                BusinessRules.Run();
                _songDal.Add(song);
                return new SuccessResult(Messages.SongAdded);
 
        }

        public IDataResult<Song> GetById(int id)
        {
            return new SuccessDataResult<Song>(_songDal.Get(s => s.SongId == id)); 
        }

        public IResult Update(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
