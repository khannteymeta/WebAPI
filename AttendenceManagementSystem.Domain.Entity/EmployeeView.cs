
namespace AttendenceManagementSystem.Domain.Entity
{
    public class EmployeeView
    {
        public Guid EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; } 

    }
}
