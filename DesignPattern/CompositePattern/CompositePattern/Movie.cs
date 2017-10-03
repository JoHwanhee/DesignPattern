using System.IO;

namespace CompositePattern
{
    class Movie
    {
        private byte[] movieData;

        public MemoryStream GetMovie()
        {
            return new MemoryStream(movieData);
        }
    }
}