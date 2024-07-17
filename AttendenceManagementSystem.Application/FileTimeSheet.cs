using AttendenceManagementSystem.Domain.Entity;
namespace AttendenceManagementSystem.Application
{
    public class FileTimeSheet : ITimeSheet
    {
        public List<Employee>? Employees { get; set; }
        public FileTimeSheet()
        {
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee emp)
        {
            //check cardNo already exist
            if (Employees.Any(e => e.CardNo == emp.CardNo))
            {
                throw new ArgumentException($"Employee with Card No '{emp.CardNo}' already exists.");
            }
            //add cardNo if unique
            Employees.Add(emp);


        }

        public void UpdateEmployee(string EmployeeId, string FullName, string Position, string Username, string Password)
        {
            // Find employee by ID
            var employeeToUpdate = Employees.FirstOrDefault(e => e.EmployeeId == new Guid(EmployeeId));

            if (employeeToUpdate != null)
            {
                // Check if cardNo will be duplicated after update
                if (Employees.Any(e => e.CardNo == employeeToUpdate.CardNo && e.EmployeeId != employeeToUpdate.EmployeeId))
                {
                    throw new ArgumentException($"Updating employee's cardNo '{employeeToUpdate.CardNo}' will cause duplicate.");
                }

                // Update employee details
                employeeToUpdate.FullName = FullName;
                employeeToUpdate.Position = Position;
            }
            else
            {
                throw new ArgumentException($"Employee with ID '{EmployeeId}' not found.");
            }


            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position))
            {
                throw new ArgumentException("please provide all employee data");
            }
            int foundIndex = Employees!.FindIndex(em => em.EmployeeId == new Guid(EmployeeId));
            Employees[foundIndex].FullName = FullName;
            Employees[foundIndex].Position = Position;
        }

        public void LogEmployee(string cardNo, Log logInfo)
        {
            if (string.IsNullOrEmpty(cardNo))
            {
                throw new ArgumentException("Card No is empty");
            }
            int foundIndex = Employees!.FindIndex(emp => emp.CardNo == cardNo.Trim());
            if (foundIndex < 0)
            {
                throw new ArgumentException($"Card no {cardNo} not found in employee list.");
            }
            Employees[foundIndex].Logs!.Add(logInfo);
        }
        public List<EmployeeView> GetAllEmployee()
        {
            //using LINQ to select data without log property
            return Employees!.Select(emp => new EmployeeView()
            {
                EmployeeId = emp.EmployeeId,
                FullName = emp.FullName,
                Position = emp.Position,
                CardNo = emp.CardNo,
            }).ToList();
        }
        public List<Employee> GetAllEmployee(bool isSimpleVersion)
        {
            return Employees!;
        }

        public void DeleteEmployee(string EmployeeId)
        {
            int index = Employees!.FindIndex(emp => emp.EmployeeId == new Guid(EmployeeId));
            if (index >= 0)
            {
                Employees.RemoveAt(index);
            }
            else
            {
                throw new ArgumentException($"Employee with ID {EmployeeId} not found.");
            }

        }
    }
}

