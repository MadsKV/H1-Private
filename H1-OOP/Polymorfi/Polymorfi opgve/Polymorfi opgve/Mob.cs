using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_opgve
{
    abstract class Mob
    {
        public double x = 0;
        public double y = 0;
        public int hp = 100;
        public double dmg = 0;
        public double speed = 0;

        public abstract bool hostile();
        public abstract bool feedAble();
        public abstract bool canAttack();
        public abstract bool explosion();
        public abstract string makeNoice();
        public abstract string makeNoiceDead();
    }
}
