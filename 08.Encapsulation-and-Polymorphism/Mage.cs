using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Mage : Character, IAttack
    {
        private int attackPoints;
        public Mage(string id, int x, int y,Team team, int healthPoints = 150, int defensePoints = 50, int range = 5, int attackPoints = 300)
            :base(id, x, y, healthPoints, defensePoints, team, range)
        {

        }

        
        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            throw new NotImplementedException();
        }

        public override void AddToInventory(Item item){

            item.ToString();
        }

        public override void RemoveFromInventory(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
