using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HighScore
{
    class HighScore:IComparer<HighScore>
    {
        public string Name;
        public int Score { get; set; }

        public int Compare(HighScore x, HighScore y)
        {
            return x.Score <= y.Score ? 1 : -1;
        }
    }
}
