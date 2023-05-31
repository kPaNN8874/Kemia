using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Felfedezések
    {
        
        public string Év;
        public int Név;
        public string Vegyjel;
        public int Rendszam;
        public string Felfedezo;

        public Felfedezések(string év, int név, string vegyjel, int rendszam, string felfedezo)
        {
            Év = év;
            Név = név;
            Vegyjel = vegyjel;
            Rendszam = rendszam;
            Felfedezo = felfedezo;
        }

        public string Év1 { get => Év;  }
        public int Név1 { get => Név;}
        public string Vegyjel1 { get => Vegyjel; }
        public int Rendszam1 { get => Rendszam; }
        public string Felfedezo1 { get => Felfedezo; }
    }
}
