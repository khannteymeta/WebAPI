
namespace AttendenceManagementSystem.Domain.Entity
{
    public class UserAccount
    {
        public int UserAccountID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        //foriegn key
        public Guid UserAccountOfEmployeeId { get; set; }

        //navigaton property
        public Employee Employee { get; set; }

    }
}
