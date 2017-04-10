using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class Program {
        static void Main(string[ ] args) {
            Archer trax = new Archer("Drow Ranger", new Point(0, 0), 125, 14);
            Druid trent = new Druid("Trent", new Point(16, 17), 640, 9);

            WarriorMemento memory = new WarriorMemento(trax);

            Console.WriteLine(trax);
            Console.WriteLine(trent);

            Console.WriteLine("\nAction:\tDrow got new rang\n");
            trax = ((trax as Warrior) + 1) as Archer;
            trax.MoveTo(new Point(18, 14));
            Console.WriteLine(trax);

            Console.WriteLine("\nAction:\tTimeback!\n");
            Restorer.Restore(trax, memory);
            Console.WriteLine(trax);

#if DEBUG
            Console.WriteLine("Press any button...");
            Console.ReadKey( );
#endif

        }
    }
}
