using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_User_task
{
    internal class User
    {
        private string _username;
        private protected string Username;
        private string _password;
        private protected string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

        }

        public void Usernamee()
        {
            Console.Write("Username: ");
            string users = Console.ReadLine();
            Username = users;
            if (users.Length > 6)
            {
                Passwword();
                _username = users;
            }
            else
            {
                Console.WriteLine("Please Enter Again");
                Usernamee();
            }
        }
        public void Passwword()

        {
            Console.Write("Password: ");

            string sifre = Console.ReadLine();
            Password = sifre;


            if (sifre == sifre.ToLower())
            {
                Console.WriteLine("Please Enter Again");
                Passwword();
            }
            else
            {
                _password = sifre;
            }
        }
    }
}
