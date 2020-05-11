using System;
using System.Drawing;

namespace labCards
{
    internal class ImageBox
    {
        private Bitmap[] images;

        public int Rows { get; }
        public int Cols { get; }
        public int Count { get; }
        public ImageBox(Bitmap image, int rows, int cols) : this(image, rows, cols, rows * cols) { }
        public ImageBox(Bitmap image, int rows, int cols, int count)
        {
            Rows = rows;
            Cols = cols;
            Count = count;
            LoadImeges(image);
        }

        public Bitmap this[int index] 
        { get 
            {
                return images[index];
            } 
        }

        private void LoadImeges(Bitmap image)
        {
            var b = new Bitmap(image);
            var w = b.Width / Cols;
            var h = b.Height / Rows;
            var n = 0;
            images = new Bitmap[Count];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols && n < Count; j++)
                {
                    images[n] = new Bitmap(w, h);
                    var g = Graphics.FromImage(images[n]);
                    g.DrawImage(b, 0, 0, new Rectangle(j * w, i * h, w, h), GraphicsUnit.Point);
                    g.Dispose();
                    n++;
                }
        }
    }
}