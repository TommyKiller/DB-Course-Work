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
    public partial class RegisterAdministrator : Form
    {
        public RegisterAdministrator()
        {
            InitializeComponent();
        }

        private void CnacelBtn_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }

        private void LoginIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void NameIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void PasswordIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (LoginIn.Text == String.Empty)
            {
                MessageBox.Show("Enter valid login!");
                return;
            }
            if (PasswordIn.Text == String.Empty || PasswordIn.Text.Length < 6)
            {
                MessageBox.Show("Enter valid password! Minimal length - 6 symbols");
                return;
            }
            if (NameIn.Text == String.Empty)
            {
                MessageBox.Show("Enter valid name!");
                return;
            }
            SqlConnection connection = Program.Connect();
            String request = "SELECT COUNT(*) FROM Administrators WHERE Login = '" + LoginIn.Text + "'";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.GetInt32(0) != 0)
            {
                MessageBox.Show("Administrator with that login already exists!");
                dataReader.Close();
                command.Dispose();
                connection.Close();
                return;
            }
            command.Dispose();
            dataReader.Close();
            SqlDataAdapter adapter = new SqlDataAdapter();
            request = String.Format("INSERT INTO Administrators (Login, Password, Full_Name) VALUES('{0}', '{1}', '{2}')", LoginIn.Text, PasswordIn.Text, NameIn.Text);
            adapter.InsertCommand = new SqlCommand(request, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Registration successful!");
            adapter.Dispose();
            connection.Close();
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }
    }
}
