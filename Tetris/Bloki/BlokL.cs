using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Bloki
{
    public class BlokL : BlokBaza
    {
       public BlokL() : base(3)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    pola[i, j] = new Pole();
                    pola[i, j].status = 0;
                    pola[i, j].kolor = Brushes.Gray;
                }
            }

            pola[1, 0].status = 2;
            pola[1, 1].status = 2;
            pola[1, 2].status = 2;
            pola[2, 2].status = 2;

            pola[1, 0].kolor = Brushes.Purple;
            pola[1, 1].kolor = Brushes.Purple;
            pola[1, 2].kolor = Brushes.Purple;
            pola[2, 2].kolor = Brushes.Purple;
        }

    }
}
