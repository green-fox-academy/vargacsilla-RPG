using RPGGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgame
{
    class Character : GameObject
    {
        public Random d6 = new Random(6);
        protected int level;
        protected int maxHealth;
        protected int currentHealth;
        protected int defendPoint;
        protected int strikePoint;
        protected bool isDead;
        protected Floor currentPlace;
    }
}
