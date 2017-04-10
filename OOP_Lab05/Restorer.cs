using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    static class Restorer {

        static public void Restore(Warrior warrior, WarriorMemento memento) {
            warrior.Name = memento.Name;
            warrior.Rang = memento.Rang;
            warrior.Position = memento.Position;
        }
    }
}
