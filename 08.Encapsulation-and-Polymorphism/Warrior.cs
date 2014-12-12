using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum
{
    class Warrior: Character, IAttack
    {
        private int attackPoints;
        public Warrior(string id, int x, int y, Team team, int healthPoints = 200, int defensePoints = 100, int range = 2, int attackPoints = 150)
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
