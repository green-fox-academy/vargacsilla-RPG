using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGGame;

namespace RPGgame
{
    class Floor : Tile
    {
        bool isOccupied;

        public Floor(double posX, double posY)
        {
            this.posX = posX;
            this.posY = posY;
            path = @"../../Assets/floor.png";
            isOccupied = false;
        }
    }
}
