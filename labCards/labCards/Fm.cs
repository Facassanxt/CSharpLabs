using labCards.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labCards
{
    public partial class Fm : Form
    {
        private Graphics g;
        private ImageBox imageBox;
        private CardPack cardPack;
        private int cardCount = 10;

        public Fm()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            g = Graphics.FromImage(pictureBox1.BackgroundImage);

            imageBox = new ImageBox(Resources.cards, 4, 13, 4*13);

            cardPack = new CardPack(imageBox.Count);

            RandomCards();
        }

        private void RandomCards()
        {
            Random rnd = new Random();
            g.Clear(SystemColors.Control);
            for (int i = 0; i < cardCount; i++)
            {
                g.DrawImage(imageBox[cardPack[i]],
                    rnd.Next(this.Width - imageBox[cardPack[i]].Width),
                    rnd.Next(this.Height - imageBox[cardPack[i]].Height)
                    );
            }
            pictureBox1.Invalidate();
        }
    }
}
