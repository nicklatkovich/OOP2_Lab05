using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab05 {
    static class MyReflector {
        public static string InfoFields(Type type) {
            string result = "";
            FieldInfo[ ] info = type.GetFields( );
            for (int i = 0; i < info.Count( ); i++) {
                result += info[i].ToString( ) + "\n";
            }
            return result;
        }

        public static string InfoInterfaces(Type type) {
            string result = "";
            Type[ ] interfaces = type.GetInterfaces( );
            for (int i = 0; i < interfaces.Count( ); i++) {
                result += interfaces[i].ToString( ) + "\n";
            }
            return result;
        }

        public static string InfoMetods(Type type) {
            string result = "";
            MethodInfo[ ] info = type.GetMethods( );
            for (int i = 0; i < info.Count( ); i++) {
                result += info[i].ToString( ) + "\n";
            }
            return result;
        }

        public static void InfoToFile(Type type, string fileName = "INFO.txt") {
            MemberInfo[ ] info = type.GetMembers( );
            StreamWriter stream = new StreamWriter(fileName);
            stream.WriteLine("Members");
            for (int i = 0; i < info.Count( ); i++) {
                stream.WriteLine(info[i]);
            }
            stream.Close( );
        }
        public static void MethodFromClass(Type type, object obj, string method, string fileName = "ATTRIBUTES.txt") {
            List<string> attrsList = new List<string>( );
            using (StreamReader stream = new StreamReader(fileName)) {
                while (stream.EndOfStream == false) {
                    attrsList.Add(stream.ReadLine( ));
                }
            }
            object[ ] attrs = new object[attrsList.Count];
            {
                uint index = 0;
                foreach (var a in attrsList) {
                    attrs[index] = a;
                }
            }
            type.GetMethod(method).Invoke(obj, attrs);
        }
    }
}
