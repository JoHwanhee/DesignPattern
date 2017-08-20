namespace BuilderPattern
{
    public class PersonInfo
    {
        private string name, animan, color;
        private int age, num;

        private PersonInfo() { }

        public class Builder
        {
            PersonInfo info = new PersonInfo();

            public Builder setName(string name) { info.name = name; return this; }
            public Builder setAge(int age) { info.age = age; return this; }
            public Builder setFavoriteAnimal(string animan) { info.animan = animan; return this; }
            public Builder setFavoriteColor(string color) { info.color = color; return this; }
            public Builder setFavoriteNumber(int num) { info.num = num; return this; }

            public PersonInfo build()
            {
                return info;
            }
        }
    }
}