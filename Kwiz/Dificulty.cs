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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Quest2 quest2 = new Quest2();
            quest2.Show();
            Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Quest3 quest3 = new Quest3();
            quest3.Show();
            Close();
        }
    }
}
