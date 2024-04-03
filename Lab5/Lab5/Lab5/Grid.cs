using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Grid
    {
    
        private bool[,] grid;
        private int cx, cy;
        public Grid()
        {

        }
        public Grid(int x, int y)
        {
            grid = new bool[x, y];
            cx = x;
            cy = y;
        }
        private int Neighbors(int x, int y)
        {
            int num = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (!(i == x && j == y)) // Skip the current cell
                    {
                        if (this[i, j])
                        {
                            num++;
                        }
                    }
                }
            }
            return num;
        }
        //code in Hint
        public bool this[int x, int y]
        {
            get
            {
                if (x < 0 || y < 0 || x >= cx || y >= cy) return false;
                return grid[x, y];
            }
            set
            {
                if (x < 0 || y < 0 || x >= cx || y >= cy) return;   //ignore out of bounds
                grid[x, y] = value;
            }
        }

        public void Generate(Grid g)
        {
            for (int i = 0; i < cx; i++)
            {
                for (int j = 0; j < cy; j++)
                {
                    int num = Neighbors(i, j);
                    if (this[i, j]) // to deal with the center square
                    {
                        if (num >= 2 && num <= 3)
                        {
                            g[i, j] = true;
                        }
                        else
                        {
                            g[i, j] = false;
                        }
                    }
                    else if (num == 3)
                    {
                        g[i, j] = true;
                    }
                    else
                    {
                        g[i, j] = false;
                    }
                }
            }
        }
    }
}
