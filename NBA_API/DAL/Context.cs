using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net;

namespace NBA_API.DAL
{
    public class Context : DbContext
    {
        public DbSet<Jugador> Jugador { get; set; }
        public DbSet<Equipo> Equipo { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>().HasData(
                new Equipo
                {
                    EquipoId = 1,
                    Nombre = "Lakers",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3c/Los_Angeles_Lakers_logo.svg/640px-Los_Angeles_Lakers_logo.svg.png"
                },
                
                new Equipo
                {
                    EquipoId = 2,
                    Nombre = "Warriors",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/0/01/Golden_State_Warriors_logo.svg/640px-Golden_State_Warriors_logo.svg.png"
                },
        
                new Equipo
                {
                    EquipoId = 3,
                    Nombre = "Bulls",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/6/67/Chicago_Bulls_logo.svg/200px-Chicago_Bulls_logo.svg.png"
                },
        
                new Equipo
                {
                    EquipoId = 4,
                    Nombre = "Knicks",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/2/25/New_York_Knicks_logo.svg/1200px-New_York_Knicks_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 5,
                    Nombre = "Celtics",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/8/8f/Boston_Celtics.svg/800px-Boston_Celtics.svg.png"
                },

                new Equipo
                {
                    EquipoId = 6,
                    Nombre = "Heat",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/f/fb/Miami_Heat_logo.svg/640px-Miami_Heat_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 7,
                    Nombre = "Nets",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/44/Brooklyn_Nets_newlogo.svg/800px-Brooklyn_Nets_newlogo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 8,
                    Nombre = "Clippers",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ed/Los_Angeles_Clippers_%282024%29.svg/1200px-Los_Angeles_Clippers_%282024%29.svg.png"
                },

                new Equipo
                {
                    EquipoId = 9,
                    Nombre = "Rockets",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/2/28/Houston_Rockets.svg/800px-Houston_Rockets.svg.png"
                },

                new Equipo
                {
                    EquipoId = 10,
                    Nombre = "Spurs",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a2/San_Antonio_Spurs.svg/240px-San_Antonio_Spurs.svg.png"
                },

                new Equipo
                {
                    EquipoId = 11,
                    Nombre = "Thunder",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/5/5d/Oklahoma_City_Thunder.svg/200px-Oklahoma_City_Thunder.svg.png"
                },

                new Equipo
                {
                    EquipoId = 12,
                    Nombre = "Suns",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/Phoenix_Suns_logo.svg/1200px-Phoenix_Suns_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 13,
                    Nombre = "Trail Blazers",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/9/93/TrailBlazers.png"
                },

                new Equipo
                {
                    EquipoId = 14,
                    Nombre = "Jazz",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Utah_Jazz_logo_2022.svg/230px-Utah_Jazz_logo_2022.svg.png"
                },

                new Equipo
                {
                    EquipoId = 15,
                    Nombre = "Wizards",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/0/02/Washington_Wizards_logo.svg/200px-Washington_Wizards_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 16,
                    Nombre = "Pistons",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Logo_of_the_Detroit_Pistons.svg/200px-Logo_of_the_Detroit_Pistons.svg.png"
                },

                new Equipo
                {
                    EquipoId = 17,
                    Nombre = "Hornets",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c4/Charlotte_Hornets_%282014%29.svg/220px-Charlotte_Hornets_%282014%29.svg.png"
                },

                new Equipo
                {
                    EquipoId = 18,
                    Nombre = "Cavaliers",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Cleveland_Cavaliers_logo.svg/170px-Cleveland_Cavaliers_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 19,
                    Nombre = "Bucks",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Milwaukee_Bucks_logo.svg/180px-Milwaukee_Bucks_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 20,
                    Nombre = "Magic",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/1/10/Orlando_Magic_logo.svg/220px-Orlando_Magic_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 21,
                    Nombre = "Sixers",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0e/Philadelphia_76ers_logo.svg/200px-Philadelphia_76ers_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 22,
                    Nombre = "Hawks",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/2/24/Atlanta_Hawks_logo.svg/200px-Atlanta_Hawks_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 23,
                    Nombre = "Nuggets",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/7/76/Denver_Nuggets.svg/200px-Denver_Nuggets.svg.png"
                },

                new Equipo
                {
                    EquipoId = 24,
                    Nombre = "Mavericks",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/9/97/Dallas_Mavericks_logo.svg/210px-Dallas_Mavericks_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 25,
                    Nombre = "Timberwolves",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c2/Minnesota_Timberwolves_logo.svg/200px-Minnesota_Timberwolves_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 26,
                    Nombre = "Pelicans",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0d/New_Orleans_Pelicans_logo.svg/250px-New_Orleans_Pelicans_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 27,
                    Nombre = "Kings",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c7/SacramentoKings.svg/180px-SacramentoKings.svg.png"
                },

                new Equipo
                {
                    EquipoId = 28,
                    Nombre = "Raptors",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/3/36/Toronto_Raptors_logo.svg/200px-Toronto_Raptors_logo.svg.png"
                },

                new Equipo
                {
                    EquipoId = 29,
                    Nombre = "Grizzlies",
                    Conferencia = "Oeste",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/f/f1/Memphis_Grizzlies.svg/190px-Memphis_Grizzlies.svg.png"
                },

                new Equipo
                {
                    EquipoId = 30,
                    Nombre = "Pacers",
                    Conferencia = "Este",
                    Imagen = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1b/Indiana_Pacers.svg/200px-Indiana_Pacers.svg.png"
                }
             );
        }
    }
}


