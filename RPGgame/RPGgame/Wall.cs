using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGGame;

namespace RPGgame
{
    class Wall : Tile
    {
        public Wall(double posX, double posY)
        {
            isAvailable = false;
            this.posX = posX;
            this.posY = posY;
            path = @"../../Assets/wall.png";
        }
    }
}
