using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class Game {

        public delegate void MethodContainer(Warrior target);

        public event MethodContainer onAttack;
        public event MethodContainer onHealing;

        public Game( ) {

        }

        public void EnterWarrior(Warrior warrior) {
            onAttack += warrior.Attack;
            onHealing += warrior.Healing;
        }

        public void Attack(Warrior warrior) {
            onAttack(warrior);
        }

        public void Healing(Warrior warrior) {
            onHealing(warrior);
        }

    }
}
