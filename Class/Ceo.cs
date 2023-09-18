
using Bank.Interface;
namespace Bank.Class
{
    internal class Ceo : Person, IPosition, IOrganize
    {
        public string? Position { get; set; }
        Credit? Credit { get; set; }
        public Ceo()
        {
            Position = null;
            Credit = null;
        }
        public Ceo(string? name, string? surname, int age, float salary, string position,Credit credit)
            : base(name, surname, age, salary)
        {
            Position = position;
            Credit = credit;
        }

        public void Organize()
        {
            Console.WriteLine("Ceo organize");

        }
        public void MakeMeeting()
        {
            Console.WriteLine("Make Meeting");
        }
        public float DecreasePercent(float percent)
        {
            Credit.Percent-=percent;
            return Credit.Percent;
        }

    }
}
