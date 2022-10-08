using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Album:IEntity
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }
        public string ReleaseYear { get; set; }
        public Song[] Songs { get; set; }

    }
}
