using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class Program {
        static void Main(string[ ] args) {
            Archer trax = new Archer("Drow Ranger", new Point(0, 0), 125, 14);
            Druid trent = new Druid("Treant Protector", new Point(16, 17), 640, 9);
            Console.WriteLine(trax);
            Console.WriteLine(trent);

            Game game = new Game( );
            game.EnterWarrior(trax);
            game.EnterWarrior(trent);
            game.Attack(trent);
            game.Attack(trax);
            game.Attack(trent);
            game.Healing(trent);

            Console.WriteLine(trax);
            Console.WriteLine(trent);

            Console.WriteLine( );
            Console.WriteLine("Archer fields:\n" + MyReflector.InfoFields(typeof(Archer)));
            Console.WriteLine("Archer methods:\n" + MyReflector.InfoMetods(typeof(Archer)));
            Console.WriteLine("Archer interfaces:\n" + MyReflector.InfoInterfaces(typeof(Archer)));

            MyReflector.InfoToFile(typeof(Archer));

            MyReflector.MethodFromClass(typeof(Archer), trax, "MoveToString");

#if DEBUG
            Console.WriteLine("\n Press any button...");
            Console.ReadKey( );
#endif

        }
    }
}
