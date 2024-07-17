

using AttendenceManagementSystem.Domain.Entity;
namespace AttendenceManagementSystem.Application
{
    public interface ITimeSheet
    {
        void AddEmployee(Employee e);
        void UpdateEmployee(string EmployeeId, string FullName, string Position, string Username, string Password);
        void LogEmployee(string cardNo, Log logInfo);
        List<EmployeeView> GetAllEmployee();
        List<Employee> GetAllEmployee(bool isSimpleVersion);
       
        void DeleteEmployee(string EmployeeId);
    }
}
