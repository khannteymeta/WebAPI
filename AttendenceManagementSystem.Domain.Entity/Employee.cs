
namespace AttendenceManagementSystem.Domain.Entity
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; }
        public  IList<Log> Logs { get; set; }
        public UserAccount? UserAccount { get; set; }

        public Employee() { }
        public Employee(string FullName, string Position, string CardNo)
        {
            this.EmployeeId = Guid.NewGuid();
            this.FullName = FullName.Trim();
            this.Position = Position.Trim();
            this.CardNo = CardNo.Trim();
            this.Logs = new List<Log>();

        }
       
    }
}
