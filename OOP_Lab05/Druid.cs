using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    sealed partial class Druid : Warrior {

        private UInt32 _manna;

        public uint MaxManna;

        public Druid(String name, Point position, UInt32 startManna = 0, UInt32 Rang = 0) : base(name, position, Rang) {
            this.Manna = this.MaxManna = startManna;
        }

        public override String ToString( ) {
            return base.ToString( ) + "\n\tManna : " + this.Manna.ToString( );
        }

        public new void DoMagic(Magic magic) {
            if (this.Manna >= magic.MannaDrink) {
                this.Manna -= magic.MannaDrink;
                // Do magic
            } else {
                throw new Exception("No more manna");
            }
        }
    }
}
