namespace Strategy._3d_Example
{
    public interface IMovieStrategy
    {
        string Title { get; }
        string Description { get; }
        DateTime ReleaseDate { get; }
        int Age();
    }
}
