using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.Bloki
{
    public class BlokO : BlokBaza
    {
        public BlokO()
        {
            int n = 2;
            Pole[,] pola = new Pole[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pola[i, j] = new Pole();
                }
            }

            pola[0, 0].status = 2;
            pola[0, 0].kolor = kolory.pomaranczowy;
            pola[0, 1].status = 2;
            pola[0, 1].kolor = kolory.pomaranczowy;


            pola[1, 0].status = 2;
            pola[1, 0].kolor = kolory.pomaranczowy;
            pola[1, 1].status = 2;
            pola[1, 1].kolor = kolory.pomaranczowy;
        }

    }
}
