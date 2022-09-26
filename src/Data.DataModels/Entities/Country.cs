using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Country: BaseEntity
    {
        public Country()
        {
            FilmProductions = new HashSet<FilmProduction>();
        }

        public string Name { get; set; }

        public virtual ICollection<FilmProduction> FilmProductions { get; set; }
    }
}
