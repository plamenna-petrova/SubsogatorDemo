using Data.DataModels.Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Actor: CrewMember
    {
        public Actor()
        {
            FilmProductionActors = new HashSet<FilmProductionActor>();
        }

        public virtual ICollection<FilmProductionActor> FilmProductionActors { get; set; }
    }
}
