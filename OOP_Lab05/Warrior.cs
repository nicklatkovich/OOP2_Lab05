using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {

    delegate string GetPointDescripion(Point point);

    abstract class Warrior : IUnitAction {

        private UInt32 _health = 100u;
        public UInt32 Health {
            get {
                return _health;
            }
            set {
                _health = Math.Max(0u, value);
            }
        }

        private String _name;
        public String Name {
            get {
                return this._name;
            }
            set {
                if (String.IsNullOrEmpty(value)) {
                    throw new Exception("No name");
                } else {
                    this._name = value;
                }
            }
        }

        public UInt32 Rang = 0;

        private Point _position;
        public Point Position {
            get {
                return this._position;
            }
            set {
                if (value != null) {
                    this._position = value;
                } else {
                    throw new NullReferenceException( );
                }
            }
        }

        public Warrior(String name, Point position, UInt32 Rang = 0) {
            this.Name = name;
            this.Position = position;
            this.Rang = Rang;
        }

        public void SetData(String name, Single x, Single y) {
            Tuple<String, Point> cortage = Cortage(name, x, y);
            this.Name = cortage.Item1;
            this.Position = cortage.Item2;
        }

        public void Attack(Warrior warrior) {
            if (warrior != this) {
                UInt32 power = (UInt32)(Utils.Random.Next( ) % Rang);
                warrior.Health -= power;
                Console.WriteLine(Name + " attack " + warrior.Name + " (-" + power + " hp)");
            }
        }

        public void Healing(Warrior warrior) {
            if (this is Druid) {
                UInt32 power = (UInt32)(Utils.Random.Next( ) % Rang);
                warrior.Health += power;
                Console.WriteLine(Name + " heal " + warrior.Name + " (+" + power + " hp)");
            }
        }

        public override String ToString( ) {
            GetPointDescripion description = point => point.ToString( );
            String result = "Warrior\n";
            result += "\tPosition : " + description(this.Position) + "\n";
            result += "\tName : " + this.Name + "\n";
            result += "\tRang : " + this.Rang + "\n";
            result += "\tHealth : " + this.Health;
            return result;
        }
        public override Boolean Equals(Object obj) {
            try {
                Warrior warrior = obj as Warrior;
                return this.Name.Equals(warrior.Name) && this.Position.Equals(warrior.Position);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public override Int32 GetHashCode( ) {
            return (~this.Position.GetHashCode( )) ^ this.Name.GetHashCode( );
        }

        public virtual void WriteToFile(String file_name) {
            System.IO.StreamWriter sw = null;
            try {
                sw = new System.IO.StreamWriter(file_name);
                sw.WriteLine(this.ToString( ));
            } finally {
                if (sw != null) {
                    sw.Close( );
                }
            }
        }

        public static Tuple<String, Point> Cortage(String name, Single X, Single Y) {
            return Tuple.Create(name, new Point(X, Y));
        }

        public void MoveTo(Point Position) {
            //if (CanMoveTo(Position)) {
            this.Position = Position;
            //}
        }

        public void MoveToString(string coords) {
            MoveTo((Point)coords);
        }

        public void DoMagic(Magic magic) {
            throw new Exception("This unit can not use magic");
        }

        public static Warrior operator +(Warrior warior, UInt32 NewRangs) {
            warior.Rang += NewRangs;
            return warior;
        }

        public static Warrior operator -(Warrior warrior, UInt32 lostRangs) {
            try {
                checked {
                    warrior.Rang -= lostRangs;
                }
            } catch (OverflowException) {
                // Negative Rang
                warrior.Rang = 0;
            }
            return warrior;
        }

        public static Boolean operator <(Warrior warrior1, Warrior warrior2) {
            return warrior1.Rang < warrior2.Rang;
        }

        public static Boolean operator >(Warrior warrior1, Warrior warrior2) {
            return warrior2 < warrior1;
        }
    }
}
