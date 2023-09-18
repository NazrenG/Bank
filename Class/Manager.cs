
using Bank.Interface;
namespace Bank.Class
{
    internal class Manager:Person, IPosition, IOrganize
    {
        public string? Position { get; set; }

        public Manager()
        {
            Position = null;
          
        }
        public Manager(string? name, string? surname, int age, float salary, string position)
            : base(name, surname, age, salary)
        {
            Position = position;
            
        }

        public void Organize()
        {
            Console.WriteLine("Manager Organize");
        }

        public void CalculateSalaries()
        {
            Console.WriteLine("Manager Calculate Salaries ");
        }
    }
}
