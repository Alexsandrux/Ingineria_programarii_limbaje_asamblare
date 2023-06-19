using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _4_reflection_emit
{
    public class Animal
    {
        private string nume;
        public string Nume { get { return nume; } set { nume = value; } }

        public Animal()
        {
            this.nume = "Grivei";
        }

        public Animal(string n)
        {
            this.nume = n;
        }

        public void latra()
        {
            Console.WriteLine(nume + " latra!");
        }

        public void doarme() 
        {
            Console.WriteLine(nume + " doarme!");

        }
    }


    public class Operatie
    {
        private int a = 0;

        public int A { get { return a; } set { a = value; } }

        public Operatie()
        {
            a = 10;
        }

        //public int adunare (int b)
        //{
        //    return a + b;
        //}


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type AnimalType = typeof(Animal);
            
            //Animal a = new Animal();

            //var AnimalType = a.GetType();

            MethodInfo animalLatraInfo = AnimalType.GetMethod("latra");

            MethodInfo[] tipuri = AnimalType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            foreach (var item in tipuri)
            {
                Console.WriteLine(item);
                
            }

            if (animalLatraInfo == null)
            {

                Console.WriteLine("Animalul nu poate latra");
            }
            else
            {
                Console.WriteLine("\nInvocare metode\n");
                object instantaAnimal = Activator.CreateInstance(AnimalType);
                animalLatraInfo.Invoke(instantaAnimal, null);
                tipuri[3].Invoke(instantaAnimal, null);
            }

            Console.WriteLine("\n\nEmit\n\n");


            int b = 20;
            int a = 10;

            DynamicMethod functie = new DynamicMethod("adunare", null, new Type[] { typeof(int), typeof(int) });
            
            ILGenerator ilAdunare = functie.GetILGenerator();




            ilAdunare.Emit(OpCodes.Ldarg_0);

            ilAdunare.Emit(OpCodes.Ldarg_1);
            ilAdunare.Emit(OpCodes.Add);

            //ilAdunare.DeclareLocal(typeof(int));
            //ilAdunare.Emit(OpCodes.Stloc_0);


            //ilAdunare.Emit(OpCodes.Ldloc_0);


            ilAdunare.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(int) }));

            ilAdunare.Emit(OpCodes.Ret);

            Action<int, int> func_ac = functie.CreateDelegate(typeof(Action<int, int>)) as Action<int, int>;
            func_ac(a, b);









            Console.WriteLine("\n\nEmit With Assembly\n\n");

            var assemblyName = new AssemblyName("HelloWorldPrinter");


            var assemblerBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);

            var assemblerModule = assemblerBuilder.DefineDynamicModule("HelloWOrldPrinterModule");
            var typeBuilder = assemblerModule.DefineType("HelloWorld", TypeAttributes.Public);

            var methodBuilder = typeBuilder.DefineMethod("Print", MethodAttributes.Public | MethodAttributes.Static);


            var il = methodBuilder.GetILGenerator();

            il.Emit(OpCodes.Ldstr, "Hello worrld!");

            var parameterTypes = new Type[1];
            parameterTypes[0] = typeof(string);

            var consoleType = Type.GetType("System.Console", true);

            var methodInfo = consoleType.GetMethod(nameof(Console.WriteLine), parameterTypes);

            il.Emit(OpCodes.Call, methodInfo);
            il.Emit(OpCodes.Ret);


            var type = typeBuilder.CreateType();

            var assembly = Assembly.GetAssembly(type);

            type.GetMethod("Print").Invoke(null, null);










            //AssemblyName assemblyName = new AssemblyName("DynamicAssembly");
            //AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);

            //ModuleBuilder mb = ab.DefineDynamicModule(assemblyName.Name + ".dll");

            //TypeBuilder tb = mb.DefineType("Operatie", TypeAttributes.Public);

            //FieldBuilder fbNume = tb.DefineField("a", typeof(string), FieldAttributes.Private);

            //MethodBuilder mbLatra = tb.DefineMethod("adunare", MethodAttributes.Public);

            //ILGenerator iLGenerator = mbLatra.GetILGenerator();
        }
    }
}
