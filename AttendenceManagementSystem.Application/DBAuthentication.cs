using AttendenceManagementSystem.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AttendenceManagementSystem.Domain;
using AttendenceManagementSystem.Infrastructure;

namespace AttendenceManagementSystem.Application
{
    public class DBAuthentication : IAuthentication
    {
        private TimeSheetDbContext _context;
        public bool IsAuthenticated { get; private set; } = false;

        public DBAuthentication(TimeSheetDbContext context) {
            _context = context;
        }
        public bool ValidateLogin(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Please provide username and password");
            }
            var user = _context.UserAccounts.Where(u => u.UserName == username.Trim() && u.Password == password.Trim()).FirstOrDefault();
            if (user == null)
            {
                return IsAuthenticated = false;
            }
            return IsAuthenticated = true;
        }
        public void LogOut()
        {
            IsAuthenticated = false;
        }

    }
}
