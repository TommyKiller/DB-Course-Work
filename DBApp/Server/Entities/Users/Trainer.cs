using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class Trainer
    {
        public Trainer(String login, String password, String name, String master_degree, int sport_id)
        {
            Login = login;
            Password = password;
            Name = name;
            Master_Degree = master_degree;
            Sport_ID = sport_id;
        }

        public String Login { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Master_Degree { get; set; }
        public int Sport_ID { get; set; }
    }
}
