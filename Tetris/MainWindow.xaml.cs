using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Tetris
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Gra gra = new Gra();
        public Plansza plansza = new Plansza();
        public MainWindow()
        {
            InitializeComponent();
            GenerujGrid(MainGrid);
            Zapiszkolor(3,3);
        }
        void GenerujGrid(Grid grid)
        {
            for (int i = 0; i < 10; i++)
            { 
                for (int j = 1; j < 23; j++) 
                {
                    Rectangle rectangle = new Rectangle
                    {
                        Fill = Brushes.Red
                    };
                    rectangle.Name = "C" + i + "R" + j;

                    Grid.SetColumn(rectangle, i);
                    Grid.SetRow(rectangle, j);
                    grid.Children.Add(rectangle);
                }        
            }

        }
        private void Zapiszkolor(int column, int row)
        {
            string name = "C" + column + "R" + row;
            Rectangle rectangle = (Rectangle)MainGrid.FindName(name);

            if (rectangle != null)
            {
                rectangle.Fill = plansza.pola[column, row-1].kolor;
            }
        }

    }
}