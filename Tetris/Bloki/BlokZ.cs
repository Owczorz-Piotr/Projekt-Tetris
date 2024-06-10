using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Bloki
{
    public class BlokZ : BlokBaza
    {
        public BlokZ() : base(3)
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

            pola[1, 1].status = 2;
            pola[2, 1].status = 2;
            pola[0, 2].status = 2;
            pola[1, 2].status = 2;

            pola[1, 1].kolor = Brushes.Yellow;            
            pola[2, 1].kolor = Brushes.Yellow;
            pola[0, 2].kolor = Brushes.Yellow;
            pola[1, 2].kolor = Brushes.Yellow;

        }

    }
}
