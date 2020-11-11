using System.ComponentModel;

namespace MovieTutorial.MovieDB
{
    public enum MovieKind
    {
        [Description("Filme")]
        Film = 1,
        [Description("Serie de TV")]
        TvSeries = 2,
        [Description("Mini Series")]
        MiniSeries = 3
    }
}
