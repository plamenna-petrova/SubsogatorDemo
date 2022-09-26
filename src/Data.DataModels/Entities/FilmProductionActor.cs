using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class FilmProductionActor: BaseEntity
    {
        public string FilmProductionId { get; set; }

        public virtual FilmProduction FilmProduction { get; set; }

        public string ActorId { get; set; }

        public virtual Actor Actor { get; set; }
    }
}
