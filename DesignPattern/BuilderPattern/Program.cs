namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonInfo.Builder personInfoBuilder = new PersonInfo.Builder();
            PersonInfo result = personInfoBuilder
                .setAge(28)
                .setFavoriteAnimal("")
                .setFavoriteColor("dd")
                .build();
        }
    }
}
