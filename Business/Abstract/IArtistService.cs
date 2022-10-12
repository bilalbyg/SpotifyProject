using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IArtistService
    {
        IDataResult<List<Artist>> GetAll();
        IResult Add(Artist artist);
        Artist GetById(int artistId);
    }
}
