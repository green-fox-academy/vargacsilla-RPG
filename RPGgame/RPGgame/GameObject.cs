using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGgame
{
    class GameObject
    {
        protected double posX;
        protected double posY;
        public string path;

        public void DrawGameObject(FoxDraw foxDraw)
        {
            foxDraw.AddImage(path, posX, posY);
        }
    }
}
