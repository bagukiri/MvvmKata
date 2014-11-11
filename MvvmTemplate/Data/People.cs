using System.Collections.Generic;

namespace MvvmTemplate.Data
{
    public class People
    {
        public List<Person> Persons
        {
            get
            {
                return new List<Person>()
                {
                    new Person() {Name = "Joe", Age = 25},
                    new Person() {Name = "Anne", Age = 35},
                    new Person() {Name = "Peter", Age = 45},
                    new Person() {Name = "David", Age = 67},
                    new Person() {Name = "Kate", Age = 15},
                    new Person() {Name = "Glenn", Age = 35},
                };
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
