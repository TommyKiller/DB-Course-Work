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
    public partial class TrainerClient : Form
    {
        private Trainer Trainer { get; set; }

        public TrainerClient(Trainer trainer)
        {
            InitializeComponent();
            Trainer = trainer;
        }
    }
}
