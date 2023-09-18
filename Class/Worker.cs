
using Bank.Interface;
namespace Bank.Class
{
    internal class Worker : Person,IPosition
    {
        public string? Position { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Operation[]? Operation { get; set; }

        public Worker()
        {
            Position = null;
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
            Operation = null;
        }
        public Worker(string? name, string? surname, int age, float salary, string position,DateTime start,DateTime end,Operation operation)
            : base(name, surname, age, salary)
        {
            Position = position;
            StartTime = start;
            EndTime = end;
           Operation.Append(operation);
        }
        public void AddOperation()
        {
            Console.WriteLine("Append operation");
        }
    }
}
