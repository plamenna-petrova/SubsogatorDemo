using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class Director: CrewMember
    {
        public Director()
        {
            FilmProductionDirectors = new HashSet<FilmProductionDirector>();
        }

        public virtual ICollection<FilmProductionDirector> FilmProductionDirectors { get; set; }
    }
}
