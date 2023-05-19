using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmitCurs10
{
    public class Persoana
    {
        public string Nume
        { get; set; }

        public int Varsta
        { get; set; }

        public override string ToString()
        {
            return "Nume: " + Nume + " Varsta: " + Varsta + " " + base.ToString();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            Persoana p = new Persoana() { Nume = "Vasile", Varsta = 50 };

            DynamicMethod functie = new DynamicMethod("Functie", null, new Type[] {typeof(Persoana), typeof(int) });

            ILGenerator il = functie.GetILGenerator();
            
            il.DeclareLocal(typeof(int));
            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Callvirt, typeof(Persoana).GetProperty("Varsta").GetGetMethod());
            il.Emit(OpCodes.Ldarg_1);
            il.Emit(OpCodes.Add);
            il.Emit(OpCodes.Stloc_0);

            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Ldloc_0);
            il.Emit(OpCodes.Callvirt, typeof(Persoana).GetProperty("Varsta").GetSetMethod());

            il.Emit(OpCodes.Ldarg_0);
            il.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] {typeof(Persoana)}));

            il.Emit(OpCodes.Ret);

            Action<Persoana, int> func_del = functie.CreateDelegate(typeof(Action<Persoana, int>)) as Action<Persoana, int>;
            func_del(p, a);        
        }
        
    }
}
