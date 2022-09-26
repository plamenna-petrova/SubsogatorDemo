using Data.DataModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataModels.Entities
{
    public class FilmProduction: BaseEntity
    {
        public FilmProduction()
        {

        }

        public string Title { get; set; }

        public int Duration { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string PlotSummary { get; set; }

        public ICollection<FilmProductionActor> FilmProductionActors { get; set; }
    }
}
