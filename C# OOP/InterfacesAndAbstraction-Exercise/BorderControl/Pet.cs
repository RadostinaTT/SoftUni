namespace BorderControl
{
    public class Pet : IBirthable, INameable
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Birthday { get; }

        public string Name { get; }
    }
}
