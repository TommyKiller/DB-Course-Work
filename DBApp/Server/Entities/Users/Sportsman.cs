using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class Sportsman
    {
        public Sportsman(String login, string password, string name, int phone)
        {
            Login = login;
            Password = password;
            Name = name;
            Phone = phone;
        }
        
        public String Login { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public int Phone { get; set; }
    }
}
