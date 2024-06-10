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
                }
            }
        }
        public Pole[,] obrot()
        {
            Pole[,] obrocony = new Pole[n,n];
            for (int i = 0; i < n; i++)
                {
                for (int j = 0; j < n; j++)
                    {
                    obrocony[j, n - 1 - i] = pola[i,j];
                    }
                }

            return obrocony;
        }
    }
}