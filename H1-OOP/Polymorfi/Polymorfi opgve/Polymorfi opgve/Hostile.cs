using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_opgve
{
    class Zombie : Mob
    {
        public Zombie()
        {
            x = 1.1;
            y = 0.8;
            hp = 100;
            dmg = 1.5;
            speed = 1.1;
        }

        public override bool canAttack()
        {
            return true;
        }
        public override bool explosion()
        {
            return false;
        }
        public override bool hostile()
        {
            return true;
        }
        public override bool feedAble()
        {
            return false;
        }
        public override string makeNoice()
        {
            return "Eeeehr";
        }
        public override string makeNoiceDead()
        {
            return "Aaaah";
        }
    }
    class Ghast : Mob
    {
        public Ghast()
        {
            x = 2.4;
            y = 2.1;
            hp = 200;
            dmg = 2.1;
            speed = 0.8;
        }
        public override bool canAttack()
        {
            return true;
        }
        public override bool explosion()
        {
            return true;
        }
        public override bool hostile()
        {
            return true;
        }
        public override bool feedAble()
        {
            return false;
        }
        public override string makeNoice()
        {
            return "Uuuhr";
        }
        public override string makeNoiceDead()
        {
            return "UHR";
        }
    }
    class Creeper : Mob
    {
        public Creeper()
        {
            x = 1.7;
            y = 1.1;
            hp = 100;
            dmg = 5.0;
            speed = 1.2;
        }
        public override bool canAttack()
        {
            return true;
        }
        public override bool explosion()
        {
            return true;
        }
        public override bool hostile()
        {
            return true;
        }
        public override bool feedAble()
        {
            return false;
        }
        public override string makeNoice()
        {
            return "Tttssh";
        }
        public override string makeNoiceDead()
        {
            return "BOOM";
        }
    }
}
