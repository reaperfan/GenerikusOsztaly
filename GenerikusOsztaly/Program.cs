using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusOsztaly
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Pont<int> p = new Pont<int>(5,5);
            Console.WriteLine(p.ToString());
            p.Def();
            Console.WriteLine(p.ToString());
            Console.WriteLine("--------------------------------------------------------");
            SzinesPont<int> szinespont = new SzinesPont<int>(10, 5, "Barna");
            EgeszSzinesPont egeszSzines = new EgeszSzinesPont(0, 0, "Szürke");
            p = szinespont as Pont<int>;
            Console.ReadKey();
        }

    }

    internal class Pont<T> where T : struct
    {
        private T x;

        public T MyX
        {
            get { return x; }
            set { x = value; }
            
       }


        private T y;
       
        public T MyY
        {
            get { return y; }
            set { y = value; }
        }
        public Pont(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "X: " + x + "\nY: " + y;
        }
        public void Def()
        {
            this.x = default(T);
            this.y = default(T);
        }
      /*  public T GetDistanceFromOrigin()
        {
            return Math.Sqrt(Math.Pow(MyX, 2) + Math.Pow(MyY, 2)); 
        }
        KORLÁT, OPERÁTOR FELÜLÍRÁSAVAL |FIX|*/


    }
    internal class SzinesPont<T> : Pont<T> where T : struct
    {
        public string MySzin { get; set; }
        public SzinesPont(T x, T y, string szin) : base(x, y)
        {
            this.MySzin = szin;
        }
    }
}
