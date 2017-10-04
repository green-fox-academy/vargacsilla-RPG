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

        public void MoveLeft(Map map)
        {
            if (map.map[posX - 1][posY].isAvailable == true && posX - 1 >= 0)
            {
                path = @"../../Assets/hero-left.png";
                posX -= 1;
            }
            return;
        }

        public void MoveRight(Map map)
        {
            if (map.map[posX + 1][posY].isAvailable == true && posX + 1 <= map.tileNumWidth)
            {
                path = @"../../Assets/hero-right.png";
                posX += 1;
            }
            return;
        }

        public void MoveDown(Map map)
        {
            if (map.map[posX][posY + 1].isAvailable == true && posY + 1 <= map.tileNumHeight)
            {
                path = @"../../Assets/hero-down.png";
                posY += 1;
            }
            return;
        }
        public void MoveUp(Map map)
        {
            if (map.map[posX][posY - 1].isAvailable == true && posY - 1 >= 0)
            {
                path = @"../../Assets/hero-up.png";
                posY -= 1;
            }
            return;
        }


        //public static void MoveUp()
        //{
        //    GameObject.posX -= 1;
        //}

        //public static void MoveDown()
        //{
        //    GameObject.posX += 1;
        //}
    }
}
