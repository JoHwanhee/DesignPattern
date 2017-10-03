using System.IO;

namespace CompositePattern
{
    class Music
    {
        private byte[] musicData;

        public MemoryStream GetMusic()
        {
            return new MemoryStream(musicData);
        }
    }
}