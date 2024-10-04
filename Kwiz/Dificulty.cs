using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwiz
{
    public partial class Dificulty : Form
    {
        public Dificulty()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Quest1 quest1 = new Quest1();
            quest1.Show();
            Close();
        }
    }
}
