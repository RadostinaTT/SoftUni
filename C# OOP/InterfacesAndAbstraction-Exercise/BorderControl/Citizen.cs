namespace BorderControl
{
    public class Citizen : IIdentifiable, INameable, IBirthable, IBuyer
    {
        public Citizen(string id, string name, int age, string birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Birthday = birthday;
            this.Food = 0;
        }

        public string Id { get; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Birthday { get; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}