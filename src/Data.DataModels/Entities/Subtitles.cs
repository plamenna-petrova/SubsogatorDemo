using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Subtitles: BaseEntity
    {
        public string Name { get; set; }

        public string FilmProductionId { get; set; }

        public virtual FilmProduction FilmProduction { get; set; }
    }
}
