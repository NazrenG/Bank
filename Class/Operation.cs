

namespace Bank.Class
{
    internal class Operation
    {
        public Guid Id { get; set; }
        public string? ProcessName { get; set; }
        public DateTime dateTime { get; set; }

        public Operation()
        {
            Id = Guid.NewGuid();
            dateTime = DateTime.Now;
            ProcessName = null;
        }

        public Operation(Guid id, string? processName, DateTime dateTime)
        {
            Id = id;
            ProcessName = processName;
            this.dateTime = dateTime;
        }
    }
}
