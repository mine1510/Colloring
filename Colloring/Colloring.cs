using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Colloring
{
    public partial class Colloring : Form
    {
        private Random random = new Random();
        private int red, green, blue, papperRed = 0, papperGreen = 0, papperBlue = 0, click = 0;

        public Colloring() //инициализирует программу
        {
            InitializeComponent();
            papperPanel.BackColor = Color.FromArgb(0, 0, 0);
            red = random.Next(0, 255);
            green = random.Next(0, 255);
            blue = random.Next(0, 255);
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void getReset()
        {
            papperPanel.BackColor = Color.FromArgb(0, 0, 0);

            redInt.Text = "000";
            papperRed = 0;

            greenInt.Text = "000";
            papperGreen = 0;

            blueInt.Text = "000";
            papperBlue = 0;

            winLabel.Text = "";

            addRed.Visible = true;
            addGreen.Visible = true;
            addBlue.Visible = true;
        }
        private void resetButton_Click(object sender, EventArgs e) // Перезапускает холст и значение цветов
        {
            getReset();
        }

        private void button1_Click(object sender, EventArgs e)  //показывает rgb искомого цвета
        {
            click += 1;
            if (click == 1)
            {
                redHelp.Text = Convert.ToString(red);
                greenHelp.Text = Convert.ToString(green);
                blueHelp.Text = Convert.ToString(blue);
            } else
            {
                click = 0;
                redHelp.Text = "";
                greenHelp.Text = "";
                blueHelp.Text = "";
            }

        }

        private void changeButton_Click(object sender, EventArgs e) //Меняет угадываемый цвет
        {
            getReset();

            red = random.Next(0, 255);
            green = random.Next(0, 255);
            blue = random.Next(0, 255);

            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void addRed_Click(object sender, EventArgs e) //добавляет красный по 10
        {
            if (papperRed < 245)
            {
                papperRed += 10;
                redInt.Text = Convert.ToString(papperRed);
                papperPanel.BackColor = Color.FromArgb(papperRed, papperGreen, papperBlue);
                getWin();
            }
        }
        private void addBlue_Click(object sender, EventArgs e) //добавляет синий по 10
        {
            if (papperBlue < 245)
            {
                papperBlue += 10;
                blueInt.Text = Convert.ToString(papperBlue);
                papperPanel.BackColor = Color.FromArgb(papperRed, papperGreen, papperBlue);
                getWin();
            }
        }

        private void addGreen_Click(object sender, EventArgs e) //добавляет зеленый по 10
        {
            if (papperGreen < 245)
            {
                papperGreen += 10;
                greenInt.Text = Convert.ToString(papperGreen);
                papperPanel.BackColor = Color.FromArgb(papperRed, papperGreen, papperBlue);
                getWin();
            }
        }

        private void getWin()
        {
            int win = 0;
            if ((papperRed - red <= 10) && (papperRed - red >= -10))  //Проверяем схожесть по красному цвету
            {
                win++;
            }

            if ((papperGreen - green <= 10) && (papperGreen - green >= -10)) //Проверяем схожесть по зеленому цвету
            {
                win++;
            }

            if ((papperBlue - blue <= 10) && (papperBlue - blue >= -10)) //Проверяем схожесть по синему цвету
            {
                win++;
            }

            if (win == 3)
            {
                winLabel.Text = "WIN";
                addRed.Visible = false;
                addGreen.Visible = false;
                addBlue.Visible = false;
            }
        }
    }
}
