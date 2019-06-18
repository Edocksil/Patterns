using System;
using System.Drawing;
using System.Windows.Forms;
namespace Kursach
{
    public partial class Form1 : Form
    {
        private Graphics _g;
        private int _x, _y, _k, _l;
        Beap beap = new Beap();
        Brush _b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void DrawBeap()//метод для малювання купи
        {
            _x = panel1.Width / 2 - 44;//координати для середини відрізка
            _y = panel1.Height / 12;//координати для середини відрізка
            _k = 2; _l = 0;//змінні що відповідають за кількість рядків та елементів в рядку відповідно
            _b = new SolidBrush(Color.Black);
            _g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            _g.Clear(Color.White);
            if (beap.Array[0] != null)//салюємо перший елемент у купі
            {
                _g.DrawRectangle(p, _x, _y, 100, 50);
                switch (beap.Array[0].ToString().Length)
                {
                    case 1: _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 30, _y + 4);
                        break;
                    case 2: _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 21, _y + 4);
                        break;
                    case 3: _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 12, _y + 4);
                        break;
                    case 4: _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 3, _y + 4);
                        break;
                }
            }
            _x = panel1.Width / 2 - 50 * (_k - 1) - 44;//змінюємо координати
            _y += 100;
            for (int i = 1; (i < beap.Array.Length); i++)//цикл для прорисовки наступних елементів
            {
                if (_y > panel1.Height && beap.HeapSize - 1 == beap.LastOfRow(beap.Height)) return;
                switch (beap.Array[i].ToString().Length)//виводимо на панель сам елемент
                {
                    case 1: _g.DrawString(beap.Array[i].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 30, _y + 4);
                        break;
                    case 2: _g.DrawString(beap.Array[i].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 21, _y + 4);
                        break;
                    case 3: _g.DrawString(beap.Array[i].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 12, _y + 4);
                        break;
                    case 4:_g.DrawString(beap.Array[i].ToString(), new Font(insertElement.Font.Name, 30), _b, _x + 3, _y + 4);
                        break;
                }
                _g.DrawRectangle(p, _x, _y, 100, 50);//малюємо прямокутник

                if (_l != _k - 1)
                {
                    _g.DrawLine(p, _x + 50, _y, _x + 92, _y - 50);//малюємо лінії
                }
                if (_l != 0)
                    _g.DrawLine(p, _x + 52, _y, _x - 10, _y - 50);
                _x += 110;
                _l++;
                if (_l == _k)
                {
                    _k++;
                    _l = 0;
                    _x = panel1.Width / 2 - 50 * (_k - 1) - 44;
                    _y += 100;
                }
            }
        }

        public void Sketch(int value)//мето для прорисовки результатів пошуку
        {
            //робота цього метода аналогічна попередньому
            DrawBeap();
            _x = panel1.Width / 2 - 44;
            _y = panel1.Height /12;
            _k = 2; _l = 0;
            _b = new SolidBrush(Color.AntiqueWhite);
            Brush stringBrush = new SolidBrush(Color.Black);
            int searchCount = beap.Count(value);
            int j = 1;
            if (searchCount == 0)//мінімальний елемент в купі
            {
                _g.FillRectangle(new SolidBrush(Color.GreenYellow), _x, _y, 100, 50);
                if (beap.Array[0].ToString().Length == 1) { _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 30, _y + 4); }
                if (beap.Array[0].ToString().Length == 2) { _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 21, _y + 4); }
                if (beap.Array[0].ToString().Length == 3) { _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 12, _y + 4); }
                if (beap.Array[0].ToString().Length == 4) { _g.DrawString(beap.Array[0].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 3, _y + 4); }
                return;
            }
            _x = panel1.Width / 2 - 50 * (_k - 1) - 44;
            _y += 100;
            while (j != searchCount)
            {
                _x += 110;
                _l++;
                if (_l == _k)
                {
                    _k++;
                    _l = 0;
                    _x = panel1.Width / 2 - 50 * (_k - 1) - 44;
                    _y += 100;
                }
                j++;
            }
            if (value == beap.Max()) _b = new SolidBrush(Color.PaleTurquoise);//колір для мінімального елемента
            _g.FillRectangle(_b, _x, _y, 100, 50);//замальвуємо максимальний елемент відповідним кольором
            if (beap.Array[j].ToString().Length == 1) _g.DrawString(beap.Array[j].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 30, _y + 4);
            if (beap.Array[j].ToString().Length == 2) { _g.DrawString(beap.Array[j].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 21, _y + 4); }
            if (beap.Array[j].ToString().Length == 3) { _g.DrawString(beap.Array[j].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 12, _y + 4); }
            if (beap.Array[j].ToString().Length == 4) _g.DrawString(beap.Array[j].ToString(), new Font(insertElement.Font.Name, 30), stringBrush, _x + 3, _y + 4);
        }

        private bool Check(string value)//перевірка текстового поля
        {
            int number;
            return int.TryParse(value, out number);
        }

        private bool CheckSearch(int value)//перевірка: знайдено елемент чи ні
        {
            return beap.Find(value);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            DrawBeap();
        }
        private void insertElement_Click_1(object sender, EventArgs e)//вставка елемента до масиву
        {
            if ((_y+100 > splitContainer1.Panel1.Height&&beap.HeapSize-1==beap.LastOfRow(beap.Height)||_x>panel1.Width))//не виходимо за межі масиву
            {
                MessageBox.Show(@"Завелика купа. Змініть розмір вікна або видальте елемент", @"Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Check(textBox1.Text))
            {
                if (CheckSearch(int.Parse(textBox1.Text)))//перевіряємо  чи існує значення в купі
                {
                    errorProvider1.SetError(textBox1, "Таке значення вже існує");
                    textBox1.Focus();
                    MessageBox.Show(@" Таке значення вже існує! Введіть інше значення", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//якщо значення не існує та дані успішно зчитані - вставляємо елемемент
                {
                    textBox1.Focus();
                    beap.Insert(int.Parse(textBox1.Text));
                    textBox1.Clear();
                }
            }
            else//повинні випрнавити помилки введення
            {
                textBox1.Focus();
                MessageBox.Show(@"Виправте помилки введення!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DrawBeap();//перемальовуємо купу
        }

        private void delete_button_Click_1(object sender, EventArgs e)//видалення елемента
        {
            if (Check(textBox1.Text))
            {
                if (!CheckSearch(int.Parse(textBox1.Text)))//перевіряємо чи існує елемент у купі
                {
                    errorProvider1.SetError(textBox1, "Такого значення не існує");
                    textBox1.Focus();
                    MessageBox.Show(@" Такго значення не існує! Введіть інше значення", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    textBox1.Focus();
                    beap.Delete(int.Parse(textBox1.Text));//видаляємо елемент
                    textBox1.Clear();
                }
            }
            else
            {
                textBox1.Focus();
                MessageBox.Show(@"Виправте помилки введення!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (beap.Empty) _g.Clear(Color.White);
            else
                DrawBeap();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)//первірка текстового поля
        {
            if (!Check(textBox1.Text) || textBox1.Text.Length > 4)//довжина елемента не повинна перевищувати 4 символи
            {
                //контролюємо, щоб користувач не зміг додати чогось зайвого
                insertElement.Enabled = false;
                delete_button.Enabled = false;
                button2.Enabled = false;
                if (textBox1.Text.Length == 0) errorProvider1.SetError(textBox1, String.Empty);
                else
                {
                    if (textBox1.Text.Length > 4) errorProvider1.SetError(textBox1, "Надто довге число");
                    else errorProvider1.SetError(textBox1, "Невірні дані");
                }
            }
            else//якщо все добре - продовжуємо операції
            {
                insertElement.Enabled = true;
                delete_button.Enabled = true;
                button2.Enabled = true;
                errorProvider1.SetError(textBox1, String.Empty);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//плшу максимуму
        {
            if (beap.Array.Length > 1)
            {
                Sketch(beap.Min());
            }
            textBox1.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)//пошук елемента
        {
            if (Check(textBox1.Text))
            {
                if (beap.Find(int.Parse(textBox1.Text)))
                {
                    Sketch(int.Parse(textBox1.Text));
                }
                else
                {
                    MessageBox.Show(@"Елемент не знайдено", @"Результати пошуку", MessageBoxButtons.OK);
                }
            }
            else
            {
                textBox1.Focus();
                MessageBox.Show(@"Виправте помилки введення!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Focus();
            textBox1.Clear();

        }

        private void button3_Click(object sender, EventArgs e)//пошук мінімуму
        {
            if (beap.Array.Length > 1)
            {
                Sketch(beap.Max());
            }
            textBox1.Focus();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawBeap();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DrawBeap();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)//видалення купи
        {
            beap.Clear();
            DrawBeap();
        }

    }
}
