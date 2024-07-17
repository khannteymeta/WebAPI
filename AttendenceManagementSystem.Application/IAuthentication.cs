 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceManagementSystem.Application
{
    public interface IAuthentication
    {
        //define property
        bool IsAuthenticated { get; }

        //define method
        bool ValidateLogin(string username, string password);
        void LogOut();
    }
}
