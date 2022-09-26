using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Genre: BaseEntity
    {
        public Genre()
        {
            FilmProductionGenres = new HashSet<FilmProductionGenre>();
        }

        public string Name { get; set; }

        public virtual ICollection<FilmProductionGenre> FilmProductionGenres { get; set; }
    }
}
