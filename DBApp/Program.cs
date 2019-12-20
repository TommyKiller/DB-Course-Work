using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    static class Program
    {
        public static ApplicationContext Context { get; set; } = new ApplicationContext();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context.MainForm = new Login();
            Application.Run(Context);
        }

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source=FIEND\\SQLEXPRESS;Initial Catalog=SportStadtDB;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
