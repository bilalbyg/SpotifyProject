using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfSongDal : EfEntityRepositoryBase<Song, DatabaseContext>, ISongDal
    {
        public List<SongDetailDto> GetSongDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from s in context.Songs
                             join a in context.Artists
                             on s.ArtistId equals a.ArtistId
                             select new SongDetailDto 
                             {
                                 SongId = s.SongId, SongName = s.SongName, 
                                 ArtistName =a.ArtistName 
                             };
                return result.ToList();
            }
        }
    }
}
