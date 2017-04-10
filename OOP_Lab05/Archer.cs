using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class Archer : Warrior {

        public UInt32 ArrowsNumber;

        public Archer(String name, Point position, UInt32 arrowNumber = 0, UInt32 Rang = 0) : base(name, position, Rang) {
            this.ArrowsNumber = arrowNumber;
        }

        public override String ToString( ) {
            return base.ToString( ) + "\n\tArrows : " + this.ArrowsNumber.ToString( );
        }
    }
}
