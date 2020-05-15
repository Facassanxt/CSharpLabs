using labCards.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        private int cardCount = 42;

        public Fm()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            Height = 1080;
            Width = 1920;

            imageBox = new ImageBox(Resources.cards, 5, 13, 4*13);

            cardPack = new CardPack(imageBox.Count);

            RandomCards();
        }

        private void RandomCards()
        {
            int angle = -90;
            Random rnd = new Random();
            g = Graphics.FromImage(pictureBox1.BackgroundImage);
            g.Clear(SystemColors.Control);
            for (int i = 0; i < cardCount; i++)
            {
                angle += 180 / cardCount;
                var ImageRotate = RotateImage(imageBox[cardPack[i]], angle,true,true,Color.Transparent);
                if (angle < 0)
                {
                    g.DrawImage(ImageRotate,
                        this.Width / 2 - cardCount * imageBox[cardPack[i]].Width / 4 + i * imageBox[cardPack[i]].Width / 4 + cardCount * imageBox[cardPack[i]].Width / 10,
                        imageBox[cardPack[i]].Height / 2);
                }
                else 
                {
                    g.DrawImage(ImageRotate,
                        this.Width / 2 - cardCount * imageBox[cardPack[i]].Width / 4 + i * imageBox[cardPack[i]].Width / 4 + cardCount * imageBox[cardPack[i]].Width / 10,
                        imageBox[cardPack[i]].Height / 2);
                }
            }
            pictureBox1.Invalidate();
        }
        public static Bitmap RotateImage(Image inputImage, float angleDegrees, bool upsizeOk,
                                   bool clipOk, Color backgroundColor)
        {
            // Test for zero rotation and return a clone of the input image
            if (angleDegrees == 0f)
                return (Bitmap)inputImage.Clone();

            // Set up old and new image dimensions, assuming upsizing not wanted and clipping OK
            int oldWidth = inputImage.Width;
            int oldHeight = inputImage.Height;
            int newWidth = oldWidth;
            int newHeight = oldHeight;
            float scaleFactor = 1f;

            // If upsizing wanted or clipping not OK calculate the size of the resulting bitmap
            if (upsizeOk || !clipOk)
            {
                double angleRadians = angleDegrees * Math.PI / 180d;

                double cos = Math.Abs(Math.Cos(angleRadians));
                double sin = Math.Abs(Math.Sin(angleRadians));
                newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
                newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);
            }

            // If upsizing not wanted and clipping not OK need a scaling factor
            if (!upsizeOk && !clipOk)
            {
                scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);
                newWidth = oldWidth;
                newHeight = oldHeight;
            }

            // Create the new bitmap object. If background color is transparent it must be 32-bit, 
            //  otherwise 24-bit is good enough.
            Bitmap newBitmap = new Bitmap(newWidth, newHeight, backgroundColor == Color.Transparent ?
                                             PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
            newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            // Create the Graphics object that does the work
            using (Graphics graphicsObject = Graphics.FromImage(newBitmap))
            {
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;

                // Fill in the specified background color if necessary
                if (backgroundColor != Color.Transparent)
                    graphicsObject.Clear(backgroundColor);

                // Set up the built-in transformation matrix to do the rotation and maybe scaling
                graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f);

                if (scaleFactor != 1f)
                    graphicsObject.ScaleTransform(scaleFactor, scaleFactor);

                graphicsObject.RotateTransform(angleDegrees);
                graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f);

                // Draw the result 
                graphicsObject.DrawImage(inputImage, 0, 0);
            }

            return newBitmap;
        }
    }
}
