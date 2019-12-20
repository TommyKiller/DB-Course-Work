using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApp
{
    public partial class ShowStadiums : Form
    {
        public ShowStadiums()
        {
            InitializeComponent();
        }

        private void ShowStadiums_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportStadtDBDataSet.Stadiums". При необходимости она может быть перемещена или удалена.
            this.stadiumsTableAdapter.Fill(this.sportStadtDBDataSet.Stadiums);

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
