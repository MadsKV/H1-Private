using System;
using System.Collections.Generic;
using System.Text;

namespace Objekter_know_how
{
    public class Punkt_i_2D
    {
        int x;
        int y;

        public Punkt_i_2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Punkt_i_2D p1)
        {
            return Math.Sqrt(Math.Pow((this.y - p1.y),2) + Math.Pow((p1.x - this.x), 2));          
        }
    }
}
