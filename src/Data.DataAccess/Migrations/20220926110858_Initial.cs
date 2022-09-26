using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screenwriters",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenwriters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmProductions",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Duration = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    PlotSummary = table.Column<string>(nullable: true),
                    CountryId = table.Column<string>(nullable: true),
                    LanguageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmProductions_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmProductions_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmProductionActors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FilmProductionId = table.Column<string>(nullable: true),
                    ActorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProductionActors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmProductionActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmProductionActors_FilmProductions_FilmProductionId",
                        column: x => x.FilmProductionId,
                        principalTable: "FilmProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmProductionDirectors",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FilmProductionId = table.Column<string>(nullable: true),
                    DirectorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProductionDirectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmProductionDirectors_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmProductionDirectors_FilmProductions_FilmProductionId",
                        column: x => x.FilmProductionId,
                        principalTable: "FilmProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmProductionGenres",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FilmProductionId = table.Column<string>(nullable: true),
                    GenreId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProductionGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmProductionGenres_FilmProductions_FilmProductionId",
                        column: x => x.FilmProductionId,
                        principalTable: "FilmProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmProductionGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmProductionScreenwriters",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    FilmProductionId = table.Column<string>(nullable: true),
                    ScreenwriterId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmProductionScreenwriters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmProductionScreenwriters_FilmProductions_FilmProductionId",
                        column: x => x.FilmProductionId,
                        principalTable: "FilmProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FilmProductionScreenwriters_Screenwriters_ScreenwriterId",
                        column: x => x.ScreenwriterId,
                        principalTable: "Screenwriters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subtitles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FilmProductionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subtitles_FilmProductions_FilmProductionId",
                        column: x => x.FilmProductionId,
                        principalTable: "FilmProductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionActors_ActorId",
                table: "FilmProductionActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionActors_FilmProductionId",
                table: "FilmProductionActors",
                column: "FilmProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionDirectors_DirectorId",
                table: "FilmProductionDirectors",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionDirectors_FilmProductionId",
                table: "FilmProductionDirectors",
                column: "FilmProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionGenres_FilmProductionId",
                table: "FilmProductionGenres",
                column: "FilmProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionGenres_GenreId",
                table: "FilmProductionGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductions_CountryId",
                table: "FilmProductions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductions_LanguageId",
                table: "FilmProductions",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionScreenwriters_FilmProductionId",
                table: "FilmProductionScreenwriters",
                column: "FilmProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmProductionScreenwriters_ScreenwriterId",
                table: "FilmProductionScreenwriters",
                column: "ScreenwriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Subtitles_FilmProductionId",
                table: "Subtitles",
                column: "FilmProductionId",
                unique: true,
                filter: "[FilmProductionId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmProductionActors");

            migrationBuilder.DropTable(
                name: "FilmProductionDirectors");

            migrationBuilder.DropTable(
                name: "FilmProductionGenres");

            migrationBuilder.DropTable(
                name: "FilmProductionScreenwriters");

            migrationBuilder.DropTable(
                name: "Subtitles");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Screenwriters");

            migrationBuilder.DropTable(
                name: "FilmProductions");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
