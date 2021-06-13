
namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
    }
}
