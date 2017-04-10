using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class WarriorMemento {

        private String _name;
        private UInt32 _rang;
        private Point _position;

        public WarriorMemento(Warrior warrior) {
            this._name = warrior.Name;
            this._rang = warrior.Rang;
            this._position = warrior.Position;
        }

        public String Name {
            get { return _name; }
            set { _name = value; }
        }

        public UInt32 Rang {
            get { return _rang; }
            set { _rang = value; }
        }

        public Point Position {
            get { return this._position; }
            set { this._position = value; }
        }
    }
}
