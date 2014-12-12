using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Healer : Character, IHeal 
    {
        private int healingPoints;
        public Healer(string id, int x, int y, Team team, int healthPoints = 75, int defensePoints = 50, int range = 6, int healingPoints = 60)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {

        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }
            set
            {
                this.healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            throw new NotImplementedException();
        }

        public override void AddToInventory(Item item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
