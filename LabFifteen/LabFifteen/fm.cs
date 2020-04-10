using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading;
using System.Text.RegularExpressions;

namespace LabFifteen
{
    public partial class fm : MaterialForm
    { 

        Logic logic = new Logic();
        List<Button> stepHistory = new List<Button>();
    
        List<Point> positionBtn;

        int countStep = 0;
        int min, sec;
        string time;

        List<Button> listBtn;
        int BXB;
        int row = 3;

        int lvlMix = 150;

        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);


            timer1.Interval = 1000;
            min = 0; sec = 0;

            StartToolStripMenuItem.Click += (s,e) => Start_Click();
            RestartToolStripMenuItem.Click += Restart_Click;
            x3ToolStripMenuItem.Click += x3_Click;
            x4ToolStripMenuItem.Click += x4_Click;
            timer1.Tick += Timer1_Tick;
            ButtomToolStripMenuItem.Click += ButtomToolStripMenuItem_Click;
            TextToolStripMenuItem.Click += TextToolStripMenuItem_Click;
            PToolStripMenuItem.Click += PToolStripMenuItem_Click;
            KeyDown += Fm_KeyDown;
            Up.Click += (s, e) =>
            {
                if (Shift.Checked) 
                {
                    SendKeys.Send("+^{UP}");
                }
                else SendKeys.Send("^{UP}");
            };
            Down.Click += (s, e) =>
            {
                if (Shift.Checked)
                {
                    SendKeys.Send("+^{DOWN}");
                }
                else SendKeys.Send("^{DOWN}");
            };
            Left.Click += (s, e) =>
            {
                if (Shift.Checked)
                {
                    SendKeys.Send("+^{LEFT}");
                }
                else SendKeys.Send("^{LEFT}");
            };
            Right.Click += (s, e) =>
            {
                if (Shift.Checked)
                {
                    SendKeys.Send("+^{RIGHT}");
                }
                else SendKeys.Send("^{RIGHT}");
            }; 
            LightToolStripMenuItem.Click += (s, e) =>
            {

                if (LightToolStripMenuItem.Text == "Темная тема") 
                {       
                    skinManager.Theme = MaterialSkinManager.Themes.DARK;
                    listBtn[listBtn.Count - 1].FlatAppearance.BorderColor = this.BackColor;
                    LightToolStripMenuItem.Text = "Светлая тема";
                }
                else
                {
                    skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    listBtn[listBtn.Count - 1].FlatAppearance.BorderColor = this.BackColor;
                    LightToolStripMenuItem.Text = "Темная тема";
                }
            };
            OkToolStripMenuItem.Click += OkToolStripMenuItem_Click;
            positionBtn = new List<Point> {  };
            listBtn = new List<Button> {};
            won.Dock = DockStyle.Bottom;

            BXB = row;
            GenButton(row);
            Start_Click();
        }

        private void PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PToolStripMenuItem.Text == "Открыть навигацию")
            {
                PA2.Visible = true;
                PToolStripMenuItem.Text = "Закрыть навигацию";
                Height = Height + PA2.Height;
            }
            else 
            {
                PA2.Visible = false;
                PToolStripMenuItem.Text = "Открыть навигацию";
                Height = Height - PA2.Height;
            }
        }

        private void OkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string s = toolStripTextBox1.Text;
            if (s != "") 
            {
                Regex regex = new Regex(@"^[1-9]?[\d]*$");
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    row = int.Parse(s);
                    if (row <= 60)
                    {
                        test();
                        row = int.Parse(s);
                        won.Visible = false;
                        ClearDataList();
                        BXB = row;
                        GenButton(row);
                        Start_Click();
                    }
                    else MessageBox.Show("Значение превышает возможности запуска, максимум 60 x 60");
                }
                else
                {
                    MessageBox.Show("Только цифры");
                }
            }
        }

        private void InitBtnClick()
        {
            for(int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].Click += button_Click;
            }
        }

        private void GenButton(int bxb)
        {
            for(int index = 0; index < bxb * bxb; index++)
            {
                Button previousBtn = new Button();
                Button btn = new Button();
                Button brBtn = new Button();
                
                if (index == 0)
                {
                    btn.Size = new Size(140, 140);
                    btn.Location = new Point(5, 70);
                    BtnStyle(btn);
                }
                else
                {
                    previousBtn = listBtn[listBtn.Count - 1];

                    if (listBtn.Count < BXB)
                    {
                        btn.Location = new Point(previousBtn.Location.X + previousBtn.Width + 5, previousBtn.Location.Y);
                    }
                    else
                    {
                        brBtn = listBtn[listBtn.Count - BXB];
                        btn.Location = new Point(brBtn.Location.X, previousBtn.Location.Y + previousBtn.Height + 5);
                        BXB += bxb;
                    }

                    btn.Size = new Size(previousBtn.Width, previousBtn.Height);
                    BtnStyle(btn);
                }

                positionBtn.Add(btn.Location);
                listBtn.Add(btn);

                Controls.Add(btn);
            }

            listBtn[listBtn.Count - 1].Tag = "0";
            listBtn[listBtn.Count - 1].Text = "✖";
            listBtn[listBtn.Count - 1].ForeColor = Color.Silver;
            listBtn[listBtn.Count - 1].BackColor = Color.Transparent;
            listBtn[listBtn.Count - 1].FlatAppearance.MouseOverBackColor = Color.Transparent;
            listBtn[listBtn.Count - 1].FlatAppearance.MouseDownBackColor = Color.Transparent;
            listBtn[listBtn.Count - 1].FlatAppearance.BorderColor = this.BackColor;

            Width = (listBtn[0].Width + 5) * bxb + 5;
            Height = (listBtn[0].Height + 5) * bxb + 70;

            won.Width = Width;
            won.Height = Height - 60;

            InitBtnClick();
        }

        private void BtnStyle(Button btn)
        {
            btn.Font = new Font("Comic Sans MS", 25);
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderSize = 2;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Text = $"{listBtn.Count + 1}";
            btn.Tag = $"{listBtn.Count + 1}";
            btn.BackColor = Color.PeachPuff;
            btn.FlatAppearance.BorderColor = Color.Silver;
        }

        private void ClearDataList()
        {
            for(int i = listBtn.Count - 1; i >= 0; i--)
            {
                Controls.Remove(listBtn[i]);
                listBtn.RemoveAt(i);
            }

            for (int i = positionBtn.Count - 1; i >= 0; i--)
            {
                positionBtn.RemoveAt(i);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
                if (sec < 10)
                    laTime.Text = $"{min}:0{sec}";
                else
                    laTime.Text = $"{min}:{sec}";
            }
            else
            {
                if (min < 59)
                {
                    sec = 0;
                    min++;
                    if (min < 10)
                        laTime.Text = $"{min}:0{sec}";
                    else
                        laTime.Text = $"{min}:{sec}";
                }
            }
        }

        // проверка на победу 
        public Boolean CheckWin(List<Button> lBtn, List<Point> lPoint)
        {
            int index = 0; 
            
            if(sec < 10)
            {
                time = $"{min}:0{sec}";
                laTime.Text = time;
            }
            else
            {
                time = $"{min}:{sec}";
                laTime.Text = time;
            }

            for (int i = lPoint.Count - 1; i >= 0; i--)
            {
                if (lBtn[i].Location == lPoint[i])
                {
                    index++;
                }
            }

            if (index == lPoint.Count)
            {
                timer1.Enabled = false;
                return true;
            }

            return false;
        }

        // кнопка собртаь в состояние win
        private void Restart_Click(object sender, EventArgs e)
        {
            logic.setWinPosition(listBtn, positionBtn);
        }

        // Кнопка перемешать 
        public void Start_Click()
        {
            laSteps.Text = "0";
            min = 0; sec = 0; countStep = 0;     
            ShuffleBlocks(listBtn[listBtn.Count - 1], listBtn, positionBtn, lvlMix);
            timer1.Enabled = true;    
        }

        private void ButtomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row * row - 1; i++)
                {
                    listBtn[i].BackColor = colorDialog1.Color;
                }
            }
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < row * row - 1; i++)
                {
                    listBtn[i].ForeColor = colorDialog1.Color;
                }
            }
        }

        private void x3_Click(object sender, EventArgs e)
        {
            test();
            won.Visible = false;
            ClearDataList();
            row = 3;
            BXB = row;
            GenButton(row);
            Start_Click();
            //System.Threading.Thread.Sleep(10050);
        }

        private void x4_Click(object sender, EventArgs e)
        {
            test();
            won.Visible = false;
            ClearDataList();
            row = 4;
            BXB = row;
            GenButton(row);
            Start_Click();
        }

        private void test()
        {
            if (PToolStripMenuItem.Text == "Закрыть навигацию")
            {
                PA2.Visible = false;
                Height = Height - PA2.Height;
                PToolStripMenuItem.Text = "Открыть навигацию";
            }
        }

        // обработчик кликов
        private void button_Click(object sender, EventArgs e)
        {
            chengeBtn((Button)sender, true);
            countStep++; 
            laSteps.Text = countStep.ToString();
        }

        // имитатор клика 
        public void RandClick(int x, int y, List<Button> lBtn, List<Point> lPoint)
        {
            for (int i = lPoint.Count - 1; i >= 0; i--)
            {
                if (x == lBtn[i].Location.X && y == lBtn[i].Location.Y)
                {
                    chengeBtn(lBtn[i]);
                }
            }
        }

        // Выбираем один блок, для имитатора клика 
        internal void ShuffleBlocks(Button block0, List<Button> lBtn, List<Point> lPoint, int lvl)
        {
            var rand = new Random();
            for (int i = 0; i < lvl; i++)
            {
                int step = rand.Next(0, 4);

                switch (step)
                {
                    case 0:
                        if (block0.Location.Y - (block0.Height + 5) < 0)
                            i--;
                        else
                            RandClick(block0.Location.X, block0.Location.Y - (block0.Height + 5), lBtn, lPoint);
                        break;
                    case 1:
                        if (block0.Location.Y + 2 * (block0.Height + 5) > Height)
                            i--;
                        else
                            RandClick(block0.Location.X, block0.Location.Y + (block0.Height + 5), lBtn, lPoint);
                        break;
                    case 2:
                        if (block0.Location.X - (block0.Width + 5) < 0)
                            i--;
                        else
                            RandClick(block0.Location.X - (block0.Width + 5), block0.Location.Y, lBtn, lPoint);
                        break;
                    case 3:
                        if (block0.Location.X + 2 * (block0.Width + 5) < 0)
                            i--;
                        else
                            RandClick(block0.Location.X + (block0.Width + 5), block0.Location.Y, lBtn, lPoint);
                        break;
                }
            }
        }


        // Проверка на возможность ходить
        public void chengeBtn(Button btn, Boolean flag = false)
        {
            if (logic.CheckStep(btn, listBtn[listBtn.Count - 1]) == true)
            {
                logic.swapBlock(btn, listBtn[listBtn.Count - 1]); // меняем блоки местами 
            }

            if (CheckWin(listBtn, positionBtn) && flag == true)
            {
                won.Visible = true;
                won.Text = $"You won!\n Your time {time}\n Steps {countStep}";
            }
            else {
                won.Visible = false;
            }
        }

        private void Fm_KeyDown(object sender, KeyEventArgs e)
        {
            Button block0 = new Button();
            block0 = listBtn[listBtn.Count - 1];
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (e.Shift)
                        for (int i = 0; i < row; i++)
                            RandClick(block0.Location.X - (block0.Width + 5), block0.Location.Y, listBtn, positionBtn);
                    else
                        RandClick(block0.Location.X - (block0.Width + 5), block0.Location.Y, listBtn, positionBtn);
                    break;
                case Keys.Right:
                    if (e.Shift)
                        for (int i = 0; i < row; i++)
                            RandClick(block0.Location.X + (block0.Width + 5), block0.Location.Y, listBtn, positionBtn);
                    else
                        RandClick(block0.Location.X + (block0.Width + 5), block0.Location.Y, listBtn, positionBtn);
                    break;
                case Keys.Up:
                    if (e.Shift)
                        for (int i = 0; i < row; i++)
                            RandClick(block0.Location.X, block0.Location.Y - (block0.Height + 5), listBtn, positionBtn);
                    else
                        RandClick(block0.Location.X, block0.Location.Y - (block0.Height + 5), listBtn, positionBtn);
                    break;
                case Keys.Down:
                    if (e.Shift)
                        for (int i = 0; i < row; i++)
                            RandClick(block0.Location.X, block0.Location.Y + (block0.Height + 5), listBtn, positionBtn);
                    else
                        RandClick(block0.Location.X, block0.Location.Y + (block0.Height + 5), listBtn, positionBtn);
                    break;
            }
        }

    }
}
