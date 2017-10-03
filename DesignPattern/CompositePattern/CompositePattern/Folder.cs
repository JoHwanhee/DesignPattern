using System.Collections.Generic;

namespace CompositePattern
{
    public class Folder : Component
    {
        public List<Component> Children { get; } = new List<Component>();

        public Folder(string name) : base(name) { }

        public bool AddComponent(Component component)
        {
            if (component == null)
            {
                return false;
            }

            Children?.Add(component);

            return true;
        }

        public bool RemoveComponent(Component component)
        {
            if (component == null)
            {
                return false;
            }

            return Children?.Remove(component) ?? false;
        }
    }
}