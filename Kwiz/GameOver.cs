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
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        Form1 menu = new Form1();

        private void guna2Button7_Click(object sender, EventArgs e)
        {
                menu.Show();
                Close();            
        }
    }
}
