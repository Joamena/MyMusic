using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace myMusic.Models
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Genre> Genre { get; set; }

    }
}