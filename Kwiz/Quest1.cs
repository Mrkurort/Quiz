using Kwiz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kwiz
{
    public partial class Quest1 : Form
    {

        private int countdownTime = 300; // Время в секундах
        private Timer timer = new Timer();

        public Quest1()
        {
            InitializeComponent();
            timer.Interval = 100; // Интервал в миллисекундах
            timer.Tick += Timer_Tick;
            guna2ProgressBar1.Maximum = countdownTime;
            guna2ProgressBar1.Value = countdownTime;
        }

        GameOver gameOver = new GameOver();
        Form1 menu = new Form1();

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            guna2ProgressBar1.Value = countdownTime;

            if (countdownTime <= 0)
            {
                timer.Stop();

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                    countdownTime = 4;
                    timer.Start();
                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = true;
                    countdownTime = 4;
                    timer.Start();
                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = true;
                    guna2ProgressBar1.Visible = false;
                    gameOver.ShowDialog();
                    menu.Show();
                    Close();
                }
            }
        }

        private async void UpdateProgressBarValue(int value)
        {
            while (guna2ProgressBar1.Value < value)
            {
                guna2ProgressBar1.Increment(1);
                await Task.Delay(10); // добавляем небольшую задержку для создания плавного эффекта
            }
        }


        private void guna2Button7_Click(object sender, EventArgs e)
        {
            var quit = MessageBox.Show("Вы действительно хотите завершить прохождение вопросов?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quit == DialogResult.Yes)
            {
                menu.Show();
                Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void Quest1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
