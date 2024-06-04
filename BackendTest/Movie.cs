namespace BackendTest
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Img { get; set; }


        public Movie(string title, int year, string genre, string director, string img)
        {
            Title = title;
            Year = year;
            Genre = genre;
            Director = director;
            Img = img;
        }
    }
}
