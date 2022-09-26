using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class FilmProductionDirector: BaseEntity
    {
        public string FilmProductionId { get; set; }

        public virtual FilmProduction FilmProduction { get; set; }

        public string DirectorId { get; set; }

        public virtual Director Director { get; set; }
    }
}
