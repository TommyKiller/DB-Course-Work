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
    public partial class Login : Form
    {
        Dictionary<String, String> requests = new Dictionary<string, string>
        {
            { "Sportsman", "SELECT *  FROM Sportsmen WHERE Login = '{0}' AND Password = '{1}'" },
            { "Administrator", "SELECT * FROM Administrators WHERE Login = '{0}' AND Password = '{1}'"},
            { "Trainer", "SELECT * FROM Trainers WHERE [Login] = '{0}' AND [Password] = '{1}'"}
        };

        public Login()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Program.Context.MainForm = RegistrationForms[UserType.SelectedItem.ToString()];
            Program.Context.MainForm.Show();
            Close();
        }

        private readonly Dictionary<String, Form> RegistrationForms = new Dictionary<string, Form>
        {
            { "Sportsman", new RegisterSportsman() },
            { "Administrator", new RegisterAdministrator() },
            { "Trainer", new RegisterTrainer() },
        };

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

        private void LoginBtn_Click(object sender, EventArgs e)
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
            SqlConnection connection = Program.Connect();
            String request = String.Format(requests[UserType.SelectedItem.ToString()], LoginIn.Text, PasswordIn.Text);
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (!dataReader.Read())
            {
                MessageBox.Show("Wrong login or password!");
                dataReader.Close();
                command.Dispose();
                connection.Close();
                return;
            }
            else
            {
                switch (UserType.SelectedItem.ToString())
                {
                    case "Sportsman":
                        break;
                    case "Trainer":
                        Trainer trainer = new Trainer(dataReader["Login"].ToString(), dataReader["Password"].ToString(), dataReader["Full_Name"].ToString(), dataReader["Master_Degree"].ToString(), Int32.Parse(dataReader["Sport_ID"].ToString()));
                        Program.Context.MainForm = new TrainerClient(trainer);
                        Program.Context.MainForm.Show();
                        Close();
                        break;
                    case "Administrator":
                        Administrator administrator = new Administrator(dataReader["Login"].ToString(), dataReader["Password"].ToString(), dataReader["Full_Name"].ToString());
                        Program.Context.MainForm = new AdministratorClient(administrator);
                        Program.Context.MainForm.Show();
                        Close();
                        break;
                    default:
                        dataReader.Close();
                        command.Dispose();
                        connection.Close();
                        Close();
                        break;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserType.SelectedIndex = 0;
        }
    }
}
