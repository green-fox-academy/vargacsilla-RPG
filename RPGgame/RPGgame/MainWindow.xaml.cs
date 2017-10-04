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
using GreenFox;
using RPGgame;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        Map myMap;
        Hero myHero;
        FoxDraw foxDraw;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            myMap = new Map(10, 10);
            myHero = new Hero();
            myMap.DrawMap(foxDraw);
            myHero.DrawGameObject(foxDraw);        
        }

        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                myMap.DrawMap(foxDraw);
                myHero.MoveLeft(myMap);
                myHero.DrawGameObject(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                myMap.DrawMap(foxDraw);
                myHero.MoveRight(myMap);
                myHero.DrawGameObject(foxDraw);
            }

            if (e.Key == Key.Up)
            {
                myMap.DrawMap(foxDraw);
                myHero.MoveUp(myMap);
                myHero.DrawGameObject(foxDraw);
            }

            if (e.Key == Key.Down)
            {
                myMap.DrawMap(foxDraw);
                myHero.MoveDown(myMap);
                myHero.DrawGameObject(foxDraw);
            }
        }
    }
}
