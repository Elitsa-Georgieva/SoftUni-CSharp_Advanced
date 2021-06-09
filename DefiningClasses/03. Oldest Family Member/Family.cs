using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        //list of people
        //method for adding members - void AddMember(Person member)
        //method returning the oldest family member – Person GetOldestMember()

        //Good practice!
        //Правим HashSet, а не List<>, за да сме сигурни, че винаги ще имаем само един човек на тези години,и че
        //ще имаме най-възрастния човек, ако имаме двама с едно и също име
        
        private readonly HashSet<Person> members;

        public Family()
        {
            //Good practice!
            //Конструктора не връща нищо, но ние трябва да си инициализираме колекцията от мембъри
            this.members = new HashSet<Person>();
        }

        public void AddMember(Person member)
        {
            //void понеже не връща нищо, само добавя мембъри
            this.members.Add(member);
        }

        public Person GetOldestMember()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();

        //достъпваме колекцията от мембъри
        //връща директно най-възрастния мембър
        //Explicitly tiped:
        //{
        //    Person person = this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //    return person;
        //}
    }
}
