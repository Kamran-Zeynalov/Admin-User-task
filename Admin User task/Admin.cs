using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_User_task
{
    internal class Admin
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string Section, string username, string password) : base(username, password)
        {
            IsSuperAdmin = isSuperAdmin;
            this.Section = Section;
        }

        public void Info()
        {
            Usernamee();
            Console.WriteLine(" ");
            Console.WriteLine($"IsSuperAdmin: {IsSuperAdmin}, Section: {Section},  Username: {Username},  Password: {Password}");
        }
    }
}
