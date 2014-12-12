using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Axe:Item
    {
        public Axe(string id, int healthEffect, int defenseEffect, int attackEffect)
            :base(id, healthEffect = 0, defenseEffect = 50, attackEffect = 75)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
