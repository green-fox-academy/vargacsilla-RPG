using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using RPGGame;

namespace RPGgame
{
    class GameObject
    {
        public int posX;
        protected int posY;
        public string path;

        public void DrawGameObject(FoxDraw foxDraw)
        {
            foxDraw.AddImage(path, posX * Tile.Width, posY * Tile.Height);
        }

        //public static void MoveLeft()
        //{
        //    GameObject.posX -= 1;
        //}

        //public static void MoveRight()
        //{
        //    GameObject.posX += 1;
        //}

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
