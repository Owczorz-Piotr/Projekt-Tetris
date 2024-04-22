using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;


namespace Tetris
{

    public abstract class BlokBaza
    {
        public int n {get; }
        public System.Windows.Media.SolidColorBrush kolor { get; }
        public int[,] pozycja { get; }

        public int[,] obrot()
        {
            int[,] obrocony = new int[n,n];
            for (int i = 0; i < n; i++)
                {
                for (int j = 0; j < n; j++)
                    {
                    obrocony[j, n - 1 - i] = pozycja[i,j];
                    }
                }

            return obrocony;
        }
    }
}