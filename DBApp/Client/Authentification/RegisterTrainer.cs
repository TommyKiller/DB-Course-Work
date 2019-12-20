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
    public partial class RegisterTrainer : Form
    {
        public RegisterTrainer()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = new Login();
            Program.Context.MainForm.Show();
            Close();
        }

        private void RegisterTrainer_Load(object sender, EventArgs e)
        {
            MasterDegreeLst.SelectedIndex = 0;
            SqlConnection connection = Program.Connect();
            String request = "SELECT ID, Name FROM Kinds_of_Sport";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                KindsOfSportLst.Items.Add(new KindOfSport(dataReader.GetInt32(0), dataReader.GetString(1)));
            }
            if (KindsOfSportLst.Items.Count > 0)
            {
                KindsOfSportLst.SelectedIndex = 0;
            }
            dataReader.Close();
            command.Dispose();
            connection.Close();
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
            SqlConnection connection = Program.Connect();
            String request = "SELECT COUNT(*) FROM Trainers WHERE Trainers.Login = '" + LoginIn.Text + "'";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            if (dataReader.GetInt32(0) != 0)
            {
                MessageBox.Show("Trainer with that login already exists!");
                dataReader.Close();
                command.Dispose();
                connection.Close();
                return;
            }
            command.Dispose();
            dataReader.Close();
            Trainer trainer = new Trainer(LoginIn.Text, PasswordIn.Text, FullNameIn.Text, MasterDegreeLst.SelectedItem.ToString(), ((KindOfSport)KindsOfSportLst.SelectedItem).ID);
            SqlDataAdapter adapter = new SqlDataAdapter();
            request = String.Format("INSERT INTO Trainers (Login, Password, Full_Name, Master_Degree, Sport_ID) VALUES('{0}', '{1}', '{2}', '{3}', {4})",trainer.Login, trainer.Password, trainer.Name, trainer.Master_Degree, trainer.Sport_ID);
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
