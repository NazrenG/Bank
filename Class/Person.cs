

namespace Bank.Class
{
    abstract class Person
    {
        public Guid guid { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public Person()
        {
            guid = Guid.NewGuid();
            Name = null; 
            Surname = null; 
            Age = 0;
            Salary = 0;
        }

        protected Person(string? name, string? surname, int age, float salary)
        {
            guid= Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }
    }
}
