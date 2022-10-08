using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISongService
    {
        IDataResult<List<Song>> GetAll();
        IDataResult<List<Song>> GetAllByCategoryId(int id);
        IDataResult<List<Song>> GetAllByArtistId(int id);
        IDataResult<List<SongDetailDto>> GetSongDetails();
        IDataResult<Song> GetById(int id);
        IResult Add(Song song);

        
    }
}
