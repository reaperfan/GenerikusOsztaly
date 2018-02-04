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


    }
}
