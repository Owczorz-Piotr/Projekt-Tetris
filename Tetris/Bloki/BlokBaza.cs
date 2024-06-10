using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Tetris;


namespace Tetris
{

    public abstract class BlokBaza
    {
        public int n;
        public Pole[,] pola;

        public BlokBaza(int size)
        {
            n = size;
            pola = new Pole[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pola[i, j] = new Pole();
                    pola[i, j].status = 0;
                    pola[i, j].kolor = Brushes.Gray;
                }
            }
        }
    }
}