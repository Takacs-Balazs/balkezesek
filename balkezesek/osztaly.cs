using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    public class jatekosok
    {
        string nev;
        int suly;
        DateTime utolso;
        DateTime elso;
        int magassag;
        public string Nev { get => nev; set => nev = value; }
        public DateTime Elso { get => elso; set => elso = value; }
        public DateTime Utolso { get => utolso; set => utolso = value; }
        public int Suly { get => suly; set => suly = value; }
        public int Magassag { get => magassag; set => magassag = value; }

        public jatekosok(string line)
        {
            string[] adat = line.Split(";");
            Nev = adat[0];
            Suly = int.Parse(adat[3]);
            Utolso = DateTime.Parse(adat[2]);
            Elso = DateTime.Parse(adat[1]);
            Magassag = int.Parse(adat[4]);
        }

    }
}
