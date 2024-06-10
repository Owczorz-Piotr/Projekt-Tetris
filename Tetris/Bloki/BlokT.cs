using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokT : BlokBaza
    {
        public BlokT() : base(3)
        {
            int n = 3;
            Pole[,] pola = new Pole[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pola[i, j] = new Pole();
                }
            }

            pola[0, 0].status = 0;
            pola[0, 1].status = 0;
            pola[0, 2].status = 0;

            pola[1, 0].status = 0;
            pola[1, 1].status = 2;
            pola[1, 1].kolor = kolory.cyjan;
            pola[1, 2].status = 0;

            pola[2, 0].status = 2;
            pola[2, 0].kolor = kolory.cyjan;
            pola[2, 1].status = 2;
            pola[2, 1].kolor = kolory.cyjan;
            pola[2, 2].status = 2;
            pola[2, 2].kolor = kolory.cyjan;
        }

    }
}
