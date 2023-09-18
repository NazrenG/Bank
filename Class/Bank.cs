

namespace Bank.Class
{
    internal class Bank
    {
        public string? Name { get; set; }
        public float Budget { get; set; }
        public float Profit { get; set; }
        public Ceo? ceos { get; set; }
        public Worker[]? workers { get; set; }
        public Manager[]? managers { get; set; }
        public Client[]? clients { get; set; }

        public Bank(string? name, float budget, float profit, Ceo? ceos, Worker[]? workers, Manager[]? managers, Client[]? clients)
        {
            Name = name;
            Budget = budget;
            Profit = profit;
            this.ceos = ceos;
            this.workers = workers;
            this.managers = managers;
            this.clients = clients;
        }

        public void CalculateProfit()
        {
            Console.WriteLine("Calculate Profit");
        }
        public void showClientCredit()
        {
            Console.WriteLine("Show Client Credit ");
        }
        public void showAllCredit()
        {
            Console.WriteLine("Show All Credit ");
        }
    }
}
