using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        Dificulty dificulty = new Dificulty();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dificulty.ShowDialog();
            Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private int _ClickLol = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            _ClickLol++;
            if (_ClickLol == 10)
            {
                Process.Start("https://www.youtube.com/watch?v=0tOXxuLcaog");
                _ClickLol = 0;
            }
        }
    }
}
