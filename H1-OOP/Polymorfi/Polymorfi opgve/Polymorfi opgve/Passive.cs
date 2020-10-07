using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfi_opgve
{
    class Sheep : Mob
    {

        public Sheep()
        {
            x = 1.5;
            y = 0.9;
            hp = 70;
            dmg = 0;
            speed = 1.2;
        }

        public override bool canAttack()
        {
            return false;
        }
        public override bool explosion()
        {
            return false;
        }
        public override bool hostile()
        {
            return false;
        }
        public override bool feedAble()
        {
            return true;
        }
        public override string makeNoice()
        {
            return "Baaaah";
        }
        public override string makeNoiceDead()
        {
            return "Eeeah";
        }
    }
    class Cow : Mob
    {
        public Cow()
        {
            x = 1.8;
            y = 1.3;
            hp = 80;
            dmg = 0;
            speed = 0.9;
        }
        public override bool canAttack()
        {
            return false;
        }
        public override bool explosion()
        {
            return false;
        }
        public override bool hostile()
        {
            return false;
        }
        public override bool feedAble()
        {
            return true;
        }
        public override string makeNoice()
        {
            return "Mooh";
        }
        public override string makeNoiceDead()
        {
            return "MOOOHAAH";
        }
    }
    class Horse : Mob
    {
        public Horse()
        {
            x = 1.9;
            y = 1.1;
            hp = 80;
            dmg = 0;
            speed = 1.5;
        }

        public override bool canAttack()
        {
            return false;
        }
        public override bool explosion()
        {
            return false;
        }
        public override bool hostile()
        {
            return false;
        }
        public override bool feedAble()
        {
            return true;
        }
        public override string makeNoice()
        {
            return "Prhup";
        }
        public override string makeNoiceDead()
        {
            return "Reeee";
        }
    }

}
