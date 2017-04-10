using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    sealed class God : Warrior {

        private static readonly Lazy<God> instance = new Lazy<God>(( ) => new God(new Point(Single.PositiveInfinity, Single.PositiveInfinity)));

        private God(Point position) : base("God", position, UInt32.MaxValue) {
            Console.WriteLine("God born!!! Amen!");
        }

        public static God Instance { get { return instance.Value; } }

        public new UInt32 Rang {
            get { return base.Rang; }
            set { throw new Exception("God's power is unlimited!!!"); }
        }
    }
}
