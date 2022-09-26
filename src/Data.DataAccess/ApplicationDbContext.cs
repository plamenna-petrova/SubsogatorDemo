using Data.DataModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataAccess
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
        {

        }

        public virtual DbSet<Actor> Actors { get; set; }

        public virtual DbSet<Country> Country { get; set; }

        public virtual DbSet<Director> Directors { get; set; }

        public virtual DbSet<FilmProduction> FilmProductions { get; set; }

        public virtual DbSet<FilmProductionActor> FilmProductionActors { get; set; }

        public virtual DbSet<FilmProductionDirector> FilmProductionDirectors { get; set; }

        public virtual DbSet<FilmProductionGenre> FilmProductionGenres { get; set; }

        public virtual DbSet<FilmProductionScreenwriter> FilmProductionScreenwriters { get; set; }

        public virtual DbSet<Genre> Genres { get; set; }

        public virtual DbSet<Language> Languages { get; set; }

        public virtual DbSet<Screenwriter> Screenwriters { get; set; }

        public virtual DbSet<Subtitles> Subtitles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=.;Database=SubsogatorDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
