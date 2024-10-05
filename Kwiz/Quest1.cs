using Kwiz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kwiz
{
    public partial class Quest1 : Form
    {
        private int Q = 0;
        

        public List<QL> AllQuest = new List<QL>
        {
            new QL(1, "Кто является автором знаменитого труда \"Сумма теологии\"", "Новичёк", "Фома Аквинский", "Фома Аквинский", "Августин Блаженный", "Альберт Великий", "Жан Данс Скот"),
            new QL(2, "Какое философское течение основывалось на идее \"двойственной истины\"", "Новичёк", "Аверроизм", "Августинизм", "Томизм", "Авиценнизм", "Аверроизм"),
            new QL(3, "Что означает термин \"трансцендентное\"", "Новичёк", "Нечто существующее вне времени и пространства", "Нечто находящееся внутри нас", "Нечто существующее вне времени и пространства", "Нечто, что можно познать эмпирически", "Нечто, что можно познать только через логику"),
            new QL(4, "Какое из перечисленных понятий не относится к философии средневековья", "Новичёк", "Эмпиризм", "Реализм", "Номинализм", "Эмпиризм", "Схоластика"),
            new QL(5, "Что является центральным понятием в философии Августина Блаженного?", "Новичёк", "Любовь как движущая сила всего сущего", "Бог как причина всего сущего", "Свобода воли человека", "Сознание как основа познания", "Любовь как движущая сила всего сущего"),
            new QL(6, "Что означает термин \"антропоцентризм\"", "Новичёк", "Постановка человека в центр вселенной", "Постановка человека в центр вселенной", "Постановка Бога в центр всего сущего", "Признание равноправия всех живых существ", "Отказ от идеи о существовании бога"),
            new QL(7, "Какое из следующих утверждений является характерным для философии средневековья", "Новичёк", "Верующий может познать бога через рассудок и вера", "Человек есть мера всех вещей", "Бог не может быть познан человеком", "Реальность состоит из атомов", "Верующий может познать бога через рассудок и вера"),
            new QL(8, "Что такое \"субстанция\"", "Новичёк", "Самостоятельно существующее вещество", "Свойство предмета", "Самостоятельно существующее вещество", "Отношение между вещами", "Действие на предмет"),
            new QL(9, "Кто из философов средневековья внес значительный вклад в развитие логики", "Новичёк", "Петр Абеляр", "Фома Аквинский", "Петр Абеляр", "Альберт Великий", "Жан Данс Скот"),
            new QL(10, "Какая из следующих философских проблем не являлась центральной для философии средневековья", "Новичёк", "Проблема смысла жизни", "Проблема соотношения веры и разума", "Проблема существования бога", "Проблема смысла жизни", "Проблема свободы воли")
        };

        public int countdownTime = 300; // Время в секундах
        public Timer timer = new Timer();

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

                Cheks();
            }
        }

        public void Cheks()
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                countdownTime = 300;
                Q++;
                QuestLoad();
                timer.Start();
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                countdownTime = 300;
                Q++;
                QuestLoad();
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

        public void QuestLoad()
        {
            try
            {

                timer.Start();

                Questions.Text = AllQuest[Q].Body.ToString();
                radioButton1.Text = AllQuest[Q].Answer1.ToString();
                radioButton2.Text = AllQuest[Q].Answer2.ToString();
                radioButton3.Text = AllQuest[Q].Answer3.ToString();
                radioButton4.Text = AllQuest[Q].Answer4.ToString();
                label2.Text = AllQuest[Q].CurentAnswer.ToString();
            }
            catch {
                GameOverG gog = new GameOverG();
                gog.Show();
                Close();
            }

        }

        private void Quest1_Load(object sender, EventArgs e)
        {
            QuestLoad();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Q++;
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null)
            {
                switch (selectedRadioButton.Name)
                {
                    case "radioButton1":
                        if (radioButton1.Text == label2.Text)
                        {
                            countdownTime = 300;
                            radioButton1.Checked = false;
                            QuestLoad();
                        }
                        else
                        {
                            countdownTime = 0;
                            radioButton1.Checked = false;

                        }
                        break;
                    case "radioButton2":
                        
                        if (radioButton2.Text == label2.Text)
                        {
                            countdownTime = 300;
                            radioButton2.Checked = false;
                            QuestLoad();
                        }
                        else
                        {
                            countdownTime = 0;
                            radioButton2.Checked = false;
                        }
                        break;
                    case "radioButton3":
                        if (radioButton3.Text == label2.Text)
                        {
                            countdownTime = 300;
                            radioButton3.Checked = false;
                            QuestLoad();
                        }
                        else
                        {
                            countdownTime = 0;
                            radioButton3.Checked = false;
                        }
                        break;
                    case "radioButton4":
                        if (radioButton4.Text == label2.Text)
                        {
                            countdownTime = 300;
                            radioButton4.Checked = false;
                            QuestLoad();
                        }
                        else
                        {
                            countdownTime = 0;
                            radioButton4.Checked = false;
                        }
                        break;
                    default:
                        MessageBox.Show("label1.Text");
                        break;
                }
                timer.Start();
            }
        }

    }

    public class QL
    {
        public int ID;
        public string Body;
        public string Lvl;
        public string CurentAnswer;
        public string Answer1;
        public string Answer2;
        public string Answer3;
        public string Answer4;

        public QL(int id, string body, string lvl, string curentAnswer, string notCurentAnswer1, string notCurentAnswer2, string notCurentAnswer3, string notCurentAnswer4)
        {
            ID = id;
            Body = body;
            Lvl = lvl;
            CurentAnswer = curentAnswer;
            Answer1 = notCurentAnswer1;
            Answer2 = notCurentAnswer2;
            Answer3 = notCurentAnswer3;
            Answer4 = notCurentAnswer4;
        }

    }
}
