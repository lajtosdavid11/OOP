using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Ember
    {
        public string nev;
        public int eletkor;
        public string bemutatkozas()
        {
            //Console.WriteLine("{0} vagyok és {1} éves", nev, eletkor);
            string valasz = $"{nev} vagyok {eletkor} éves"; 
            return valasz;

        }
    }
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Ember Pisti = new Ember();
            Ember Eva = new Ember();

            Eva.nev = "Nagy Éva";
            Eva.eletkor = 18;

            Pisti.nev = "Nagy Pisti";
            Pisti.eletkor = 20;

            Pisti.eletkor++;

            Console.WriteLine(Pisti.bemutatkozas());
            Console.WriteLine(Eva.bemutatkozas());

            Console.ReadKey();
        }
    }
}