using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISongService
    {
        List<Song> GetAll();
        List<Song> GetAllByCategoryId(int id);
        List<Song> GetAllByArtistId(int id);
        List<SongDetailDto> GetSongDetails();
    }
}
