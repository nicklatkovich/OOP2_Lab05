using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    sealed partial class Druid : Warrior {
        public UInt32 Manna {
            get { return this._manna; }
            set {
                if (value > this.MaxManna) {
                    throw new Exception("Overload of intelligence");
                }
                this._manna = value;
            }
        }
    }
}
