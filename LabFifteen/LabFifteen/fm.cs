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

namespace LabFifteen
{
    public partial class fm : MaterialForm
    { 

        Logic logic = new Logic();
        List<Button> stepHistory = new List<Button>();
    
        List<Point> positionBtn;

        int countStep = 0;
        int min, sec;

        List<Button> listBtn;
        int BXB;
        int row;

        int lvlMix = 1000;

        public fm()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);


            timer1.Interval = 1000;
            min = 0; sec = 0;

            Start.Click += Start_Click;
            Restart.Click += Restart_Click;
            timer1.Tick += Timer1_Tick;
      
            positionBtn = new List<Point> {  };
            listBtn = new List<Button> {};
            
            row = 3;
            BXB = row;
            GenButton(row);
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
                    btn.Location = new Point(0, 64);
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
            listBtn[listBtn.Count - 1].Visible = false;

            Width = (listBtn[0].Width + 9) * bxb - (bxb * 6);
            Height = (listBtn[0].Height + 9) * bxb + 47;

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
                laTime.Text = $"{min}:0{sec}";
            }
            else
            {
                laTime.Text = $"{min}:{sec}";
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
        private void Start_Click(object sender, EventArgs e)
        {
            laSteps.Text = "0";
            min = 0; sec = 0; countStep = 0;     
            ShuffleBlocks(listBtn[listBtn.Count - 1], listBtn, positionBtn, lvlMix);
            timer1.Enabled = true;          
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
                if (x == lBtn[i].Location.X || y == lBtn[i].Location.Y)
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
            }
            else {
                won.Visible = false;
            }
        }

    }
}
