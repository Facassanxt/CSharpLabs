using Ex.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class Game : MaterialForm
    {
        private Point CurPoint;
        List<Rectangle> _list_collision, _list_collision_items;
        Rectangle rectangle;
        Bitmap _map_Game;
        ImageList _pics;
        Point _Person_Location;
        public Game(Bitmap map_Game, Point Person_Location, List<Rectangle> list_collision, List<Rectangle> list_collision_items, ImageList pics) 
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey900, Primary.Blue50, Accent.Lime400, TextShade.WHITE);

            piGame.Location = new Point(0, 64);
            piGame.Width = Screen.PrimaryScreen.Bounds.Width;
            piGame.Height = Screen.PrimaryScreen.Bounds.Height;
            CurPoint = new Point(-(Person_Location.X - piGame.Width/2), -(Person_Location.Y - piGame.Height/2));
            piGame.Paint += (s, e) => { e.Graphics.DrawImage(map_Game, CurPoint); };
            piPlayer.Parent = piGame;
            piPlayer.Image = Resources._Left;
            piPlayer.Location = new Point(Person_Location.X - (Person_Location.X - piGame.Width / 2), Person_Location.Y - (Person_Location.Y - piGame.Height / 2));
            KeyDown += Game_KeyDown;
            _list_collision = list_collision;
            _list_collision_items = list_collision_items;
            _map_Game = map_Game;
            _pics = pics;
            _Person_Location = Person_Location;
            PiPreviewMAP.Location = new Point(0, 64);
            piMapPlayer.Parent = PiPreviewMAP;
            piMapPlayer.Size = new Size(PiPreviewMAP.Width / (map_Game.Width / 60), PiPreviewMAP.Height / (map_Game.Height / 60));
            MessageBox.Show($"{piMapPlayer.Size}");
            PiPreviewMAP.Paint += (s, e) => { e.Graphics.DrawImage(map_Game, 0, 0, PiPreviewMAP.Width, PiPreviewMAP.Height); };
            //KeyUp += (s, e) => { piPlayer.Enabled = false; };
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            piMapPlayer.Location = new Point(PiPreviewMAP.Width * (_Person_Location.X - CurPoint.X) / _map_Game.Width, PiPreviewMAP.Height * _Person_Location.Y / _map_Game.Height);
            PiPreviewMAP.Invalidate();
            rectangle = new Rectangle(piPlayer.Location.X - CurPoint.X, piPlayer.Location.Y - CurPoint.Y, piPlayer.Width, piPlayer.Height);
            foreach (Rectangle check_collision in _list_collision_items)
                if (rectangle.IntersectsWith(check_collision))
                {
                    using (Graphics g = Graphics.FromImage(_map_Game))
                    {
                        g.DrawImage(_pics.Images[24 - 1], check_collision);
                    }
                }
            switch (e.KeyCode)
            {
                case Keys.Left:

                    piPlayer.Image = Resources._Left;
                    foreach (Rectangle check_collision in _list_collision)
                        if (rectangle.IntersectsWith(check_collision))
                        {
                            CurPoint = new Point(CurPoint.X - 20, CurPoint.Y);
                            return;
                        }
                    if (e.Shift)
                    {
                        CurPoint = new Point(CurPoint.X + 10, CurPoint.Y);
                    }
                    else
                    {
                        CurPoint = new Point(CurPoint.X + 2, CurPoint.Y);
                    }
                    break;
                case Keys.Right:
                    piPlayer.Image = Resources._Right;
                    foreach (Rectangle check_collision in _list_collision)
                        if (rectangle.IntersectsWith(check_collision))
                        {
                            CurPoint = new Point(CurPoint.X + 20, CurPoint.Y);
                            return;
                        }
                    if (e.Shift)
                    {
                        CurPoint = new Point(CurPoint.X - 10, CurPoint.Y);
                    }
                    else
                    {
                        CurPoint = new Point(CurPoint.X - 2, CurPoint.Y);
                    }
                    break;
                case Keys.Up:
                    piPlayer.Image = Resources._Up;
                    foreach (Rectangle check_collision in _list_collision)
                        if (rectangle.IntersectsWith(check_collision))
                        {
                            CurPoint = new Point(CurPoint.X, CurPoint.Y - 20);
                            return;
                        }
                    if (e.Shift)
                    {
                        CurPoint = new Point(CurPoint.X, CurPoint.Y + 10);
                    }
                    else
                    {
                        CurPoint = new Point(CurPoint.X, CurPoint.Y + 2);
                    }
                    break;
                case Keys.Down:
                    piPlayer.Image = Resources._Down;
                    foreach (Rectangle check_collision in _list_collision)
                        if (rectangle.IntersectsWith(check_collision))
                        {
                            CurPoint = new Point(CurPoint.X, CurPoint.Y + 20);
                            return;
                        }
                    if (e.Shift)
                    {
                        CurPoint = new Point(CurPoint.X, CurPoint.Y - 10);
                    }
                    else
                    {
                        CurPoint = new Point(CurPoint.X, CurPoint.Y - 2);
                    }
                    break;
            }
            piGame.Refresh();
        }
    }
}
