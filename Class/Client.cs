
namespace Bank.Class
{
    internal class Client : Person
    {
        public string? LiveAdress { get; set; }
        public string? WorkAdress { get; set; }

        public Client()
        {
            LiveAdress = null;
            WorkAdress = null;

        }
        public Client(string? name, string? surname, int age, float salary, string live,string work)
            : base(name, surname, age, salary)
        {

            LiveAdress = live;
            WorkAdress = work;
        }
    }
}
