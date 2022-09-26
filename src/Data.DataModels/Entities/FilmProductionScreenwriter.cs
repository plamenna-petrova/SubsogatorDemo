using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class FilmProductionScreenwriter: BaseEntity
    {
        public string FilmProductionId { get; set; }

        public virtual FilmProduction FilmProduction { get; set; }

        public string ScreenwriterId { get; set; }

        public virtual Screenwriter Screenwriter { get; set; }
    }
}
