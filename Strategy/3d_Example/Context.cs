namespace Strategy._3d_Example
{
    internal class Context
    {
        private IEnumerable<IMovieStrategy> _movieStrategies;

        public Context(IEnumerable<IMovieStrategy> movieStrategies)
        {
            _movieStrategies = movieStrategies;
        }
        public void ShowMovie(string Title)
        {
            IMovieStrategy movie = _movieStrategies.
                SingleOrDefault(x => x.Title == Title) ?? throw new Exception("Movie not found");

            Console.WriteLine(movie.Title);
            Console.WriteLine(movie.Description);
            Console.WriteLine($"{movie.ReleaseDate} ({movie.Age()} years old)");
        }
    }
}
