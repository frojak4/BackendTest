
namespace BackendTest
{
    public class Program
    {
        public static List<Movie> movielist = new List<Movie>()
        {
            new Movie("Inception", 2010, "Science Fiction", "Christopher Nolan", "https://m.media-amazon.com/images/I/81p+xe8cbnL._AC_SY679_.jpg"),
            new Movie("The Shawshank Redemption", 1994, "Drama", "Frank Darabont", "https://m.media-amazon.com/images/I/51zUbui+gbL._AC_SY679_.jpg"),
            new Movie("The Godfather", 1972, "Crime", "Francis Ford Coppola", "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg"),
            new Movie("The Dark Knight", 2008, "Action", "Christopher Nolan", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_.jpg"),
            new Movie("Pulp Fiction", 1994, "Crime", "Quentin Tarantino", "https://m.media-amazon.com/images/I/71c05lTE03L._AC_SY679_.jpg"),
            new Movie("Forrest Gump", 1994, "Drama", "Robert Zemeckis", "https://m.media-amazon.com/images/I/91++WV6FP4L._AC_UF894,1000_QL80_.jpg"),
            new Movie("The Matrix", 1999, "Science Fiction", "Lana Wachowski, Lilly Wachowski", "https://m.media-amazon.com/images/I/51EG732BV3L._AC_SY679_.jpg"),
            new Movie("Fight Club", 1999, "Drama", "David Fincher", "https://m.media-amazon.com/images/I/51v5ZpFyaFL._AC_SY679_.jpg"),
            new Movie("Interstellar", 2014, "Science Fiction", "Christopher Nolan", "https://m.media-amazon.com/images/I/91kFYg4fX3L._AC_SY679_.jpg"),
            new Movie("The Lord of the Rings: The Return of the King", 2003, "Fantasy", "Peter Jackson", "https://m.media-amazon.com/images/I/51Qvs9i5a%2BL._AC_SY679_.jpg")
        };

        public static void Main(string[] args)
        {


            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseHttpsRedirection();

            app.MapGet("/test", () =>
            {
                return movielist;
            });

            app.MapPost("/test", (Movie movie) =>
            {
                movielist.Add(movie);
            });

            app.UseStaticFiles();
            app.Run();
        }
    }
}
