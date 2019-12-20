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
    public partial class AddStadium : Form
    {
        public AddStadium()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AdressIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != 8)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (NameIn.Text == String.Empty)
            {
                MessageBox.Show("Enter the name!");
                return;
            }
            if (AdressIn.Text == String.Empty)
            {
                MessageBox.Show("Enter the adress!");
                return;
            }
            if (Int32.Parse(LengthIn.Text) <= 0 || Int32.Parse(NumberIn.Text) <= 0 || Int32.Parse(SitsIn.Text) <= 0)
            {
                MessageBox.Show("Enter valid data!");
                return;
            }
            SqlConnection connection = Program.Connect();
            String request = "SELECT * FROM Sport_Buildings WHERE Adress = '" + AdressIn.Text + "'";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Building with that adress already exists in the base!");
                reader.Close();
                command.Dispose();
                connection.Close();
                return;
            }
            else
            {
                reader.Close();
                command.Dispose();
                AddBuilding(connection, AdressIn.Text);
                int ID = GetBuildingID(connection, AdressIn.Text);
                NewStadium(connection, ID);
                connection.Close();
                Close();
            }
        }

        private void NewStadium(SqlConnection connection, int ID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            String request = String.Format("INSERT INTO Stadiums (Building_ID, Name, Treadmill_Len, Treadmill_Num, Sits_Num) VALUES({0}, '{1}', {2}, {3}, {4})",
                ID, NameIn.Text, Int32.Parse(LengthIn.Text), Int32.Parse(NumberIn.Text), Int32.Parse(SitsIn.Text));
            adapter.InsertCommand = new SqlCommand(request, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Dispose();
        }

        private void AddBuilding(SqlConnection connection, String adress)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            String request = String.Format("INSERT INTO Sport_Buildings (Adress) VALUES('{0}')", adress);
            adapter.InsertCommand = new SqlCommand(request, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            adapter.Dispose();
        }

        private int GetBuildingID(SqlConnection connection, String adress)
        {
            String request = "SELECT ID FROM Sport_Buildings WHERE Adress = '" + adress + "'";
            SqlCommand command = new SqlCommand(request, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                reader.Close();
                command.Dispose();
                return ID;
            }
            else
            {
                reader.Close();
                command.Dispose();
                return -1;
            }
        }
    }
}
