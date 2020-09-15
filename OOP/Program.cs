using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Teglalap
    {
        public int kerulet;
        public int terulet;
        
        public string keruletMetodus()
        {
            string valasz = $"{kerulet}";
            return valasz;
        }
        public string teruletMetodus()
        {
            string valasz = $"{terulet}";
            return valasz;
        }


    }

    public string kor()
    {

    }
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Teglalap a = new Teglalap();
            Teglalap b = new Teglalap();
            a.kerulet = 5;
            b.terulet = 10;
            Console.WriteLine("Kerulet {0}",a.keruletMetodus());
            Console.WriteLine("Terulet {0}",b.teruletMetodus());



            Console.ReadKey();
        }
    }
}