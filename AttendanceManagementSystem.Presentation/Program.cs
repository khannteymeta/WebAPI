using AttendenceManagementSystem.Domain.Entity;
using AttendenceManagementSystem.Application;
using AttendenceManagementSystem.Infrastructure;
namespace AttendanceManagementSystem.Presentation
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            ApplicationConfiguration.Initialize();

            //create database context obj
            TimeSheetDbContext db = new TimeSheetDbContext();

            //set data into database if database empty
            db.Database.EnsureCreated();

            
            var emp = db.Employees.FirstOrDefault();
            if (emp == null)
            {
                var aEmp = new Employee()
                {
                    FullName = "Admin",
                    Position = "Admin",
                    CardNo = "001",
                    UserAccount = new UserAccount()
                    {
                        UserName = "Admin",
                        Password = "123"
                    }
                };
                db.Employees.Add(aEmp);
              
                db.SaveChanges();
            }

            // create DBTimeSheet object
            var AppTimeSheet = new DBTimeSheet(db);

            // create Authentication object
            var AppAuth = new DBAuthentication(db);

            System.Windows.Forms.Application.Run(new MainForm(AppTimeSheet,AppAuth));

            Application.Run(new EmployeeForm());
        }
    }
}