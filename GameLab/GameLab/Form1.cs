using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLab
{
    public partial class Form1 : Form
    {
        string nl = "\r\n";

        Journal journal;
        GameDirector director;
        GameBuilder builder;
        Game dungeon;

        TextBox[] names;
        TextBox[] hp;
        TextBox[] bounty;

        string[] defaultName;

        int i, f;//крок, об'єкт гри

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonMove.Enabled = false;
            buttonStart.Enabled = false;

            journal = Journal.getInstance();
            director = new GameDirector();

            defaultName = new string[] { "Червоний", "Синій", "Зелений", "Жовтий" };
        }

        private void CreateTB(Game dungeon)
        {
            names = new TextBox[dungeon.Players.Length];
            hp = new TextBox[dungeon.Players.Length];
            bounty = new TextBox[dungeon.Players.Length];

            for (int a = 0, x = 6, y = 45; a < dungeon.Players.Length; a++)
            {
                names[a] = new TextBox();
                names[a].Location = new Point(x, y);
                names[a].Size = new Size(100, 22);
                names[a].Text = defaultName[a].ToString();
                groupBox1.Controls.Add(names[a]);
                groupBox1.Show();
                y += 65;
            }

            for (int a = 0, x = 10, y = 30; a < dungeon.Players.Length; a++)
            {
                hp[a] = new TextBox();
                hp[a].Location = new Point(x, y);
                hp[a].Size = new Size(47, 22);
                hp[a].Text = dungeon.Players[a].HPnow.ToString();
                hp[a].Enabled = false;
                groupBox2.Controls.Add(hp[a]);
                groupBox2.Show();
                y += 65;
            }

            for (int a = 0, x = 10, y = 30; a < dungeon.Players.Length; a++)
            {
                bounty[a] = new TextBox();
                bounty[a].Location = new Point(x, y);
                bounty[a].Size = new Size(37, 42);
                bounty[a].Text = dungeon.Players[a].BountyNow.ToString();
                bounty[a].Enabled = false;
                groupBox3.Controls.Add(bounty[a]);
                groupBox3.Show();
                y += 65;
            }

        }

        private void toolStripFor2_Click(object sender, EventArgs e)
        {
            journal.Clear();

            LogText.Text = "Розпочато гру для 2." + nl + "Введіть імена гравців (за бажанням)";

            builder = new TemplateGame.GameFor2();

            director.CreateBuilder(builder);

            buttonStart.Enabled = true;

            dungeon = director.GetGame();

            CreateTB(dungeon);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (i <= dungeon.Moves)
            {
                textBoxMoves.Text = (dungeon.Moves - i).ToString();
                LogText.Text += nl + nl + "Крок: " + i;
                for (int p = 0; p < dungeon.Players.Length; p++)
                {
                    hp[p].Text = dungeon.Players[p].HPnow.ToString();
                    bounty[p].Text = dungeon.Players[p].BountyNow.ToString();
                    dungeon.GameObjects[f].Action(dungeon.Players[p]);
                    LogText.Text += journal.LastLog();
                    f++;
                }
            }
            else
            {
                string escaped = "Врятувалися: ", dead = "Загинули: ";
                
                for(int p=0; p<dungeon.Players.Length;p++)
                {
                    if (dungeon.Players[p].HPnow > 0)
                    {
                        escaped += nl + dungeon.Players[p].Name + " та заробив: " + dungeon.Players[p].BountyNow.ToString() +" ₴";
                    }
                    else { dead += nl + dungeon.Players[p].Name; }
                }

                MessageBox.Show(escaped + nl + nl + dead);
            }
            i++;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int p = 0; p < dungeon.Players.Length; p++)
            {
                dungeon.Players[p].Name = names[p].Text;
            }

            i = 1;
            f = 0;

            buttonMove.Enabled = true;
            buttonStart.Enabled = false;
        }

        private void toolStripFor3_Click(object sender, EventArgs e)
        {
            journal.Clear();

            LogText.Text = "Розпочато гру для 3." + nl + "Введіть імена гравців (за бажанням)";

            builder = new TemplateGame.GameFor3();

            director.CreateBuilder(builder);

            buttonStart.Enabled = true;

            dungeon = director.GetGame();

            CreateTB(dungeon);
        }

        private void toolStripFor4_Click(object sender, EventArgs e)
        {
            journal.Clear();

            LogText.Text = "Розпочато гру для 4." + nl + "Введіть імена гравців (за бажанням)";

            builder = new TemplateGame.GameFor4();

            director.CreateBuilder(builder);

            buttonStart.Enabled = true;

            dungeon = director.GetGame();

            CreateTB(dungeon);
        }

        private void toolStripRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Виберіть кількіcть гравці" + nl + "2) Змініть імена за бажанням" + nl + "3) ???" + nl + "4) Починайте гру, засновану на рандомі");
        }
    }
}
