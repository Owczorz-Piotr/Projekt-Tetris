using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokI : BlokBaza
    {
        public BlokI() : base(4)
        {
            int n = 4;
            Pole[,] pola = new Pole[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pola[i, j] = new Pole();
                }
            }

            pola[0, 0].status = 2;
            pola[0, 0].kolor = kolory.niebieski;
            pola[0, 1].status = 0;
            pola[0, 2].status = 0;
            pola[0, 3].status = 0;

            pola[1, 0].status = 2;
            pola[1, 0].kolor = kolory.niebieski;
            pola[1, 1].status = 0;
            pola[1, 2].status = 0;
            pola[1, 3].status = 0;

            pola[2, 0].status = 2;
            pola[2, 0].kolor = kolory.niebieski;
            pola[2, 1].status = 0;
            pola[2, 2].status = 0;
            pola[2, 3].status = 0;

            pola[3, 0].status = 2;
            pola[3, 0].kolor = kolory.niebieski;
            pola[3, 1].status = 0;
            pola[3, 2].status = 0;
            pola[3, 3].status = 0;
        }

    }
}
