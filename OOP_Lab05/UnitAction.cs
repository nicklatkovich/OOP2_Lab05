using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    interface IUnitAction {
        void WriteToFile(string file_name);
        void MoveTo(Point Posotion);
        void DoMagic(Magic magic);
    }
}
