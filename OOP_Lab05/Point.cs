using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    class Point {

        Single X;
        Single Y;
        public Point(Single X, Single Y) {
            this.X = X;
            this.Y = Y;
        }
        public override String ToString( ) {
            return "(" + X + ", " + Y + ")";
        }
        public override Boolean Equals(Object obj) {
            if (obj == null) {
                return false;
            }
            Point point = obj as Point;
            if (point == null) {
                return false;
            }
            return (this.X == point.X && this.Y == point.Y);
        }
        public override Int32 GetHashCode( ) {
            Int32 x = ~BitConverter.ToInt32(BitConverter.GetBytes(this.X), 0);
            Int32 y = BitConverter.ToInt32(BitConverter.GetBytes(this.Y), 0);
            return (~x) ^ y;
        }
    }
}
