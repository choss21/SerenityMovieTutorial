using Serenity.Navigation;
using MyPages = MovieTutorial.MovieDB.Pages;

[assembly: NavigationMenu(1000, "Catalogos", icon: "fa-television")]
[assembly: NavigationLink(1000, "Catalogos/Peliculas", typeof(MyPages.MovieController), icon: "fa-file-movie-o")]
[assembly: NavigationLink(1000, "Catalogos/Generos", typeof(MyPages.GenreController), icon: null)]
[assembly: NavigationLink(1000, "Catalogos/Paises", typeof(MyPages.CountryController), icon: null)]
[assembly: NavigationLink(1000, "Catalogos/Estados", typeof(MyPages.StateCountryController), icon: null)]