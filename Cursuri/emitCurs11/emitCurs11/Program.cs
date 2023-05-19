using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace emitCurs11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssemblyName an = new AssemblyName();
            an.Name = "Test_add";
            AppDomain domain = AppDomain.CurrentDomain;

            AssemblyBuilder ab = domain.DefineDynamicAssembly(an, AssemblyBuilderAccess.Save);

            ModuleBuilder mb = ab.DefineDynamicModule(an.Name, "Test.exe");

            TypeBuilder tb = mb.DefineType("Demo.Test", TypeAttributes.Public | TypeAttributes.Class);

            MethodBuilder fb = tb.DefineMethod("Main", MethodAttributes.Public | MethodAttributes.Static);

            ILGenerator il = fb.GetILGenerator();

            il.Emit(OpCodes.Ldstr, "Dati un numar ");
            il.Emit(OpCodes.Call, typeof(Console).GetMethod("Write", new Type[] { typeof(string)} ));
            il.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));


            il.Emit(OpCodes.Call, typeof(Convert).GetMethod("ToInt32", new Type[] { typeof(string) }));

            il.Emit(OpCodes.Ldc_I4, 10);
            il.Emit(OpCodes.Mul);

            il.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(int)}));
            il.Emit(OpCodes.Call, typeof(Console).GetMethod("ReadLine"));

            il.Emit(OpCodes.Pop);
            il.Emit(OpCodes.Ret);

            Type t = tb.CreateType();
            ab.SetEntryPoint(fb, PEFileKinds.ConsoleApplication);

            ab.Save("Test.exe");

            Console.WriteLine("Aplicatia a fost construita!!!");


            Console.ReadLine();


        }
    }
}
