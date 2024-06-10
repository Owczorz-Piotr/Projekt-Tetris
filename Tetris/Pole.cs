using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris
{
    public class Pole
    {
        public int status; // 0 = puste pole, 1 = pole zajęte, 2 = pole przenieszczające się
        public Brush kolor;
    }
}
