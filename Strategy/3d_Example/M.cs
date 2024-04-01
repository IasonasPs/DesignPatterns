using Strategy._3d_Example;
namespace Strategy
{
    class M : IMovieStrategy  //This class is an example of a Concrete strategy
    {
        public string Title => "asdf";

        public string Description => "Description   asasdasdasd";

        public DateTime ReleaseDate => DateTime.UtcNow;

        public int Age()
        {
            var seconds =(int)(DateTime.Now - ReleaseDate).TotalMilliseconds/1000;
            return seconds;
        }
    }

}

