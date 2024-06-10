using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Bloki
{
    public class BlokJ : BlokBaza
    {
        public BlokJ() : base(3)
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

                pola[0, 1].status = 2;
                pola[1, 1].status = 2;
                pola[2, 1].status = 2;
                pola[2, 2].status = 2;


                pola[0, 1].kolor = Brushes.Green;
                pola[1, 1].kolor = Brushes.Green;
                pola[2, 1].kolor = Brushes.Green;
                pola[2, 2].kolor = Brushes.Green;
            }

    }
}
