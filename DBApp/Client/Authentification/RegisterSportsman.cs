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
    public partial class RegisterSportsman : Form
    {
        public RegisterSportsman()
        {
            InitializeComponent();
        }

        private void PhoneIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
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
            if (FullNameIn.Text == String.Empty)
            {
                MessageBox.Show("Enter valid name!");
                return;
            }
            if (PhoneIn.Text == String.Empty || PhoneIn.Text.Length < 10)
            {
                MessageBox.Show("Enter phone number!");
                return;
            }
            SqlConnection connection = Program.Connect();
            String request = "SELECT COUNT(*) FROM Sportsmen WHERE Sportsmen.Login = '" + LoginIn.Text + "'";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.GetInt32(0) != 0)
            {
                MessageBox.Show("Sportsman with that login already exists!");
                dataReader.Close();
                command.Dispose();
                connection.Close();
                return;
            }
            command.Dispose();
            dataReader.Close();
            SqlDataAdapter adapter = new SqlDataAdapter();
            request = String.Format("INSERT INTO Sportsmen (Login, Password, Full_Name, Phone) VALUES('{0}', '{1}', '{2}', {3})", LoginIn.Text, PasswordIn.Text, FullNameIn.Text, Int32.Parse(PhoneIn.Text));
            adapter.InsertCommand = new SqlCommand(request, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("Registration successful!");
            adapter.Dispose();
            connection.Close();
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }

        private void LoginIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PasswordIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FullNameIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
