using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Song:IEntity
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }
        public int CategoryId { get; set; }
        public string SongName { get; set; }
        public int Duration { get; set; }
    }
}
