

namespace Curs2
{

    //interface IObservator
    //{
    //    void Notificare();

    //}

    //interface IObservabil
    //{
    //    void Cupleaza(IObservator obj);

    //    void Decupleaza(IObservator obj);
    //}

    //class Observabil : IObservabil
    //{
    //    protected List<IObservator> observatori = new List<IObservator>();
    //    public void Cupleaza(IObservator obj)
    //    {
    //        observatori.Add(obj);
    //    }

    //    public void Decupleaza(IObservator obj)
    //    {
    //        observatori.Remove(obj);
    //    }


    //}

    //class Consola : IObservator
    //{
    //    public void Notificare()
    //    {
    //        Console.WriteLine("Modificare stare!!");
    //    }
    //}

    //class Element : Observabil
    //{
    //    int x;

    //    public Element()
    //    {
    //        x = 0;
    //    }

    //    public int Valore { get { return x; } set { if(value != x) x = value; foreach (IObservator item in observatori)
    //            {
    //                item.Notificare();   
    //            }
    //        } }
    //}

    class Consola 
    {
        public void Notificare()
        {
            Console.WriteLine("Modificare stare!!");
        }
    }

    class Element
    {
        int x;

        public delegate void del_functie(); // delegate functie

        public event del_functie evenimentSchimba;

        public Element()
        {
            x = 0;
        }

        public int Valore
        {
            get { return x; }
            set
            {
                if (value != x)
                {
                    x = value;
                    if (evenimentSchimba != null)
                        evenimentSchimba();
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Consola obiectConsola = new Consola();

            Element obiectElement = new Element();

            //obiectElement.Cupleaza(obiectConsola);

            //obiectElement.Valore = 100;
            //Console.ReadLine();
            //obiectElement.Decupleaza(obiectConsola);

            //obiectElement.Valore = 200;

            obiectElement.evenimentSchimba += obiectConsola.Notificare;
            obiectElement.Valore = 100;
            Console.ReadLine();
            obiectElement.evenimentSchimba -= obiectConsola.Notificare;
            obiectElement.Valore = 100;
        }
    }
}