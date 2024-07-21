using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AttendenceManagementSystem.Domain.Entity;
using AttendenceManagementSystem.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;

namespace AttendenceManagementSystem.Application
{
    public class DBTimeSheet : ITimeSheet
    {
        private TimeSheetDbContext _dbContext;
        public DBTimeSheet(TimeSheetDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _dbContext.Database.ExecuteSqlRaw("PRAGMA foreign_keys = ON;");

        }

        public void AddEmployee(Employee emp)
        {


            if (string.IsNullOrEmpty(emp.FullName) ||
                string.IsNullOrEmpty(emp.Position) ||
                string.IsNullOrEmpty(emp.CardNo) ||

                string.IsNullOrEmpty(emp.UserAccount.UserName) ||
                string.IsNullOrEmpty(emp.UserAccount.Password))
               

            {
                throw new ArgumentException("Please provide all employee data !");
            }
            else
            {
                _dbContext.Employees.Add(emp);
                _dbContext.SaveChanges();
            }
           
            /*
             
            //check cardNo already exist
            if (_dbContext.Employees.Any(e => e.CardNo == emp.CardNo))
            {
                throw new ArgumentException($"Employee with Card No '{emp.CardNo}' already exists.");
            }
            //add cardNo if unique
            _dbContext.Employees.Add(emp);

            */


        }
        
        private bool IsAllDigits(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void UpdateEmployee(string EmployeeId, string FullName, string Position)
        {

            //check for empty data
            if (string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position))
            {
                throw new ArgumentNullException("Please provide all employee data !");
            }
            var emp = _dbContext.Employees.Find(new Guid(EmployeeId));
            if (emp == null)
            {
                throw new ArgumentNullException("Employee is not found !");
            }

            // update employee datta
            emp.FullName = FullName;
            emp.Position = Position;
            _dbContext.SaveChanges();
        }
        public void LogEmployee(string cardNo, Log Info)
        {
            if (string.IsNullOrEmpty(cardNo))
            {
                //check empty card
                throw new ArgumentNullException("CardNo is empty !");
            }
            var emp = _dbContext.Employees.Include(l => l.Logs).FirstOrDefault(emp => emp.CardNo == cardNo.Trim());
            if (emp == null)
            {
                throw new ArgumentNullException($"CordNo {cardNo} not found in employee list");
            }
            emp.Logs!.Add(Info);
            _dbContext.SaveChanges();
        }
        public List<EmployeeView> GetAllEmployee()
        {
            //using LINO to select data without log prperty
            return _dbContext.Employees.Select(emp => new EmployeeView()
            {
                EmployeeId = emp.EmployeeId,
                FullName = emp.FullName,
                Position = emp.Position,
                CardNo = emp.CardNo
            }).ToList();
        }
        public List<Employee> GetAllEmployee(bool isSimpleVersion)
        {
            return _dbContext.Employees.ToList();
        }
        public void DeleteEmployee(string EmployeeId)
        {


            var employee = _dbContext.Employees.Find(new Guid(EmployeeId));
            if (employee == null)
            {
                throw new ArgumentException($"Employee with ID '{EmployeeId}' does not exist.");
            }

            _dbContext.Employees.Remove(employee);
            _dbContext.SaveChanges();


        }
    }
}
