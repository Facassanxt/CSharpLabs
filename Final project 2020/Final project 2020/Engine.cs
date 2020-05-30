using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Engine
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Ticks { get; set; }
        private bool[,] Grid { get; set; }

        public Engine(int h, int w)
        {
            Height = h;
            Width = w;
            Ticks = 0;
            Grid = new bool[h, w];
        }

        public bool this[int y, int x]
        {
            get
            {
                return Grid[y, x];
            }
            set
            {
                Grid[y, x] = value;
            }
        }

        public async void Tick()
        {
            await Task.Run(() =>
            {
                bool[,] clone = new bool[Height, Width];
                for (var j = 0; j < Height; ++j)
                    for (var i = 0; i < Width; ++i)
                        clone[j, i] = GetNextValue(j, i);

                Grid = clone;
                ++Ticks;
            });
        }

        private int GetLiveNeighbours(int y, int x)
        {
            int count = 0;
            for (var j = y - 1; j < y + 2; ++j)
                for (var i = x - 1; i < x + 2; ++i)
                    if (!(j < 0 || j >= Height || i < 0 || i >= Width)) 
                        count += Convert.ToInt32(Grid[j, i]);
            return count - Convert.ToInt32(Grid[y, x]);
        }

        private bool GetNextValue(int y, int x)
        {
            switch (GetLiveNeighbours(y, x))
            {
                case 2:
                    return Grid[y, x];
                case 3:
                    return true;
                default:
                    return false;
            }
        }
    }
}
