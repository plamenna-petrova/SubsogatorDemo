using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Language: BaseEntity
    {
        public Language()
        {
            FilmProductions = new HashSet<FilmProduction>();
        }

        public string Name { get; set; }

        public virtual ICollection<FilmProduction> FilmProductions { get; set; }
    }
}
