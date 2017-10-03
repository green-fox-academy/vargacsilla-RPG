using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGGame;
using System.Windows.Input;

namespace RPGgame
{
    class Hero : Character
    {
        public Hero()
        {
            level = 1;
            currentHealth = 20 + 3 * d6.Next();
            defendPoint = 2 * d6.Next();
            strikePoint = 5 + d6.Next();

            path = @"../../Assets/hero-down.png";
            posX = 0;
            posY = 0;
        }

        public void Move(KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                posX -= Tile.Width;
            }

            if (e.Key == Key.Right)
            {
                posX += Tile.Width;
            }

            if (e.Key == Key.Up)
            {
                posX -= Tile.Height;
            }

            if (e.Key == Key.Down)
            {
                posX += Tile.Height;
            }
        }
    }
}
