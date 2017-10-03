namespace CompositePattern
{
    public class File<T> : Component
    {
        public File(string name, T data) : base(name)
        {
            Data = data;
        }
        public T Data { get; set; }
    }
}