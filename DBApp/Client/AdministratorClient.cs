using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class AdministratorClient : Form
    {
        private Administrator Administrator { get; set; }

        public AdministratorClient(Administrator administrator)
        {
            InitializeComponent();

            Administrator = administrator;
        }

        private void stadiumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStadium addStadium = new AddStadium();
            addStadium.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Program.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter();
            String request = "DELETE Administrators WHERE Login = '" + Administrator.Login + "'";
            adapter.DeleteCommand = new SqlCommand(request, connection);
            adapter.DeleteCommand.ExecuteNonQuery();
            adapter.Dispose();
            connection.Close();
            Administrator = null;
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }

        private void stadiumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStadiums show = new ShowStadiums();
            show.ShowDialog();
        }
    }
}
