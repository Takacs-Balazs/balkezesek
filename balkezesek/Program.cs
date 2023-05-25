using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using balkezesek;

namespace balkezesek
{
    internal class program
    {
        static void Main(string[] args)
        {
             List<jatekosok> lista = new List<jatekosok>();
            StreamReader sr = new StreamReader("balkezesek.csv");
            sr.ReadLine();
            while (sr.EndOfStream) { lista.Add(new jatekosok(sr.ReadLine())); } sr.Close();

            Console.WriteLine($"3.feladat: {lista.Count}");
            
            Console.WriteLine("4. feladat: Utolsó pályára lépés 1999 októberben:");
            lista.Where(x => x.Utolso.Year == 1999 && x.Utolso.Month == 10).ToList().ForEach(y => Console.WriteLine($"\t{y.Nev}, {String.Format("{0:0.0}", y.Magassag * 2.54)} cm"));

        }
    }


}
