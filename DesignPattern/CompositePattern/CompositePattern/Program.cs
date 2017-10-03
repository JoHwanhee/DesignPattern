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


            root.AddComponent(user01);
                user01.AddComponent(music);
                    music.AddComponent(사랑안해);
                    music.AddComponent(사랑비);

            root.AddComponent(user02);
                user02.AddComponent(movie);
                    movie.AddComponent(영화는영화다);
                    movie.AddComponent(괜찮아사랑이야);

                user02.RemoveComponent(movie);

            Prt(root);
        }

        public static void Prt(Component rootComponent)
        {
            if (rootComponent == null)
            {
                return;
            }

            Console.WriteLine(rootComponent.Name);

            if (rootComponent is Folder folder)
            {
                foreach (Component component in folder.Children)
                {
                    Prt(component);
                }
            }

            if (rootComponent is File<object> file)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
