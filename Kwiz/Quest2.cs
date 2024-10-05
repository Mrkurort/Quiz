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
    public partial class Quest2 : Form
    {
        private int Q = 0;
        

        public List<QL2> AllQuest = new List<QL2>
        {
            new QL2(1, "Кто является автором знаменитого труда \"Сумма теологии\"", "Новичёк", "Фома Аквинский", "Фома Аквинский", "Августин Блаженный", "Альберт Великий", "Жан Данс Скот"),
            new QL2(2, "Какое философское течение основывалось на идее \"двойственной истины\"", "Новичёк", "Аверроизм", "Августинизм", "Томизм", "Авиценнизм", "Аверроизм"),
            new QL2(3, "Что означает термин \"трансцендентное\"", "Новичёк", "Нечто существующее вне времени и пространства", "Нечто находящееся внутри нас", "Нечто существующее вне времени и пространства", "Нечто, что можно познать эмпирически", "Нечто, что можно познать только через логику"),
            new QL2(4, "Какое из перечисленных понятий не относится к философии средневековья", "Новичёк", "Эмпиризм", "Реализм", "Номинализм", "Эмпиризм", "Схоластика"),
            new QL2(5, "Что является центральным понятием в философии Августина Блаженного?", "Новичёк", "Любовь как движущая сила всего сущего", "Бог как причина всего сущего", "Свобода воли человека", "Сознание как основа познания", "Любовь как движущая сила всего сущего"),
            new QL2(6, "Что означает термин \"антропоцентризм\"", "Новичёк", "Постановка человека в центр вселенной", "Постановка человека в центр вселенной", "Постановка Бога в центр всего сущего", "Признание равноправия всех живых существ", "Отказ от идеи о существовании бога"),
            new QL2(7, "Какое из следующих утверждений является характерным для философии средневековья", "Новичёк", "Верующий может познать бога через рассудок и вера", "Человек есть мера всех вещей", "Бог не может быть познан человеком", "Реальность состоит из атомов", "Верующий может познать бога через рассудок и вера"),
            new QL2(8, "Что такое \"субстанция\"", "Новичёк", "Самостоятельно существующее вещество", "Свойство предмета", "Самостоятельно существующее вещество", "Отношение между вещами", "Действие на предмет"),
            new QL2(9, "Кто из философов средневековья внес значительный вклад в развитие логики", "Новичёк", "Петр Абеляр", "Фома Аквинский", "Петр Абеляр", "Альберт Великий", "Жан Данс Скот"),
            new QL2(10, "Какая из следующих философских проблем не являлась центральной для философии средневековья", "Новичёк", "Проблема смысла жизни", "Проблема соотношения веры и разума", "Проблема существования бога", "Проблема смысла жизни", "Проблема свободы воли"),

            new QL2(11, "Какое из следующих утверждений лучше всего отражает основную идею \"универсалий\"", "Знающий", "Универсалии - это абстрактные идеи, которые воплощаются в реальных предметах", "Универсалии существуют только в нашей голове","Универсалии - это абстрактные идеи, которые воплощаются в реальных предметах", "Универсалии - это реальные вещи, существующие отдельно от индивидуальных предметов", "Универсалии - это языковые символы, обозначающие классы объектов"),
            new QL2(12, "Кто из философов средневековья разработал концепцию \"двойственной истины\"", "Знающий", "Аверроэс", "Фома Аквинский","Августин Блаженный", "Альберт Великий", "Аверроэс"),
            new QL2(13, "Что подразумевается под термином \"креационизм\"", "Знающий", "Теория, согласно которой мир был создан Богом", "Теория происхождения жизни из неживой материи","Теория, согласно которой вселенная возникла в результате взрыва", "Теория, согласно которой мир был создан Богом", "Теория, согласно которой человек - это высшее существо, которое может управлять миром"),
            new QL2(14, "В каком веке началась эпоха средневековья", "Знающий", "V веке", "V веке", "III веке","IX веке", "XII веке"),
            new QL2(15, "Кто из философов средневековья был известен своими работами по логике и диалектике", "Знающий", "Петр Абеляр", "Фома Аквинский", "Петр Абеляр","Роджер Бэкон", "Альберт Великий"),
            new QL2(16, "Как называется метод рассуждения, основанный на строгих логических правилах и дедукции", "Знающий", "Схоластика", "Схоластика", "Эмпиризм","Реализм", "Номинализм"),
            new QL2(17, "Какое из перечисленных понятий не относится к философии средневековья", "Знающий", "Эгоцентризм", "Познаваемость Бога","Свобода воли", "Провиденция", "Эгоцентризм"),
            new QL2(18, "Что такое \"схоластика\"", "Знающий", "Метод преподавания философии, основанный на диалектических спорах", "Направление в искусстве, которое характеризуется символизмом и мистицизмом", "Метод преподавания философии, основанный на диалектических спорах","Теория, которая утверждает, что мир создан Богом", "Направление в философии, основанное на изучении классических авторов"),
            new QL2(19, "Что такое \"естественный закон\"", "Знающий", "Законы, вытекающие из природы человека и его рациональности", "Законы, которые можно познать только через эмпирическое наблюдение","Законы, основанные на религиозных учениях", "Законы, вытекающие из природы человека и его рациональности", "Законы, принятые государством"),
            new QL2(20, "Как называлось учение, утверждающее, что мир создан Богом", "Знающий", "Креационизм", "Креационизм", "Пантеизм","Эволюционизм", "Атеизм")
        };

        public int countdownTime = 200; // Время в секундах
        public Timer timer = new Timer();

        public Quest2()
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
                countdownTime = 200;
                Q++;
                QuestLoad();
                timer.Start();
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                countdownTime = 200;
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
            catch
            {
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
                            countdownTime = 200;
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
                            countdownTime = 200;
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
                            countdownTime = 200;
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
                            countdownTime = 200;
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
                
            }
            timer.Start();
        }

    }

    public class QL2
    {
        public int ID;
        public string Body;
        public string Lvl;
        public string CurentAnswer;
        public string Answer1;
        public string Answer2;
        public string Answer3;
        public string Answer4;

        public QL2(int id, string body, string lvl, string curentAnswer, string notCurentAnswer1, string notCurentAnswer2, string notCurentAnswer3, string notCurentAnswer4)
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
