using System;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder root = new Folder("root");
            Folder user01 = new Folder("user01");
            Folder user02 = new Folder("user02");
            Folder music = new Folder("music");
            Folder movie = new Folder("movie");

            File<Music> 사랑안해 = new File<Music>("사랑안해", new Music());
            File<Music> 사랑비 = new File<Music>("사랑비", new Music());
            File<Movie> 영화는영화다 = new File<Movie>("영화는영화다", new Movie());
            File<Movie> 괜찮아사랑이야 = new File<Movie>("괜찮아사랑이야", new Movie());


            if (root.AddComponent(user01))
            {
                if (user01.AddComponent(music))
                {
                    if (music.AddComponent(사랑안해))
                    {
                        
                    }

                    if (music.AddComponent(사랑비))
                    {
                        
                    }
                }
            }




            if (root.AddComponent(user02))
            {
                if (user02.AddComponent(movie))
                {
                    if (movie.AddComponent(영화는영화다))
                    {

                    }
                    if (movie.AddComponent(괜찮아사랑이야))
                    {

                    }
                }

            }
          
            root.Print();
        }
    }
}
