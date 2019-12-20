using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class Administrator
    {
        public Administrator(String login, String password, String name)
        {
            Login = login;
            Password = password;
            Name = name;
        }

        public String Login { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
    }
}
