using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Plansza
    {
        public Pole[,] pola = new Pole[10, 26];

        public void nowa_gra()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 26; j++)
                {
                    pola[i, j] = new Pole();
                    pola[i, j].status = 0;
                    pola[i, j].kolor = kolory.szary;
                }
        }


        public void spawdz_usun()
        {
            for (int i = 0; i < 22; i++)
            {
                int spawdz = 0;
                for (int j = 0; j < 10; j++)
                    if (pola[i, j].status == 1)
                        spawdz++;
                if (spawdz == 10)
                {
                    for (int i2 = i; i2 < 21; i2++)
                    {
                        for (int j = 0; j < 10; j++)
                            pola[i2, j] = pola[i2 + 1, j];
                    }
                    i--;
                }
            }
        }
    }
}
