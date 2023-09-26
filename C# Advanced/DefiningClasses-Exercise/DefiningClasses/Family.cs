using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();
        
        public List<Person> People {
            get { return this.people; }
            set { this.people = value; }
        }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember()
        {
            var oldestPerson = this.People.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestPerson;
        }
    }
}
