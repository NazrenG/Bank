
namespace Bank.Class
{
    internal class Credit
    {
        public Guid Id { get; set; }
        public Client? Client { get; set; }
        public float Amount { get; set; }
        public float Percent { get; set; }

        public Credit()
        {
            Id = Guid.NewGuid();
            Client = new Client();
            Amount =0; 
            Percent = 0;
        }

        public Credit(Client? client, float amount, float percent)
        {
            Client = client;
            Amount = amount;
            Percent = percent;
        }

        public void CalculatePercent()
        {
            Console.WriteLine("Credit Calculate Percent ");
        }
        public void Payment()
        {
            Console.WriteLine("Credit Payment");
        }
    }
}
