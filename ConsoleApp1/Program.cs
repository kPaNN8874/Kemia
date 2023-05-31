using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Felfedezések> felfedezes = new List<Felfedezések>();
            StreamReader sr = new StreamReader("felfedezesek.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var mezok = sr.ReadLine().Split(';');
                felfedezes.Add(new Felfedezések(mezok[0], int.Parse(mezok[1]), mezok[3], int.Parse(mezok[4]), mezok[5])) ;
            }
            sr.Close();

            //3.feladat
            Console.WriteLine($"3. feladat: Elemek száma: {felfedezes.Where(x=>x.Vegyjel).Count()}");
            //4.feladat
            Console.WriteLine($"4. feladat: Felfedezések az ókorban: {felfedezes.Év.Contains(x=>x == "Ókor").Count()}");
            //5.feladat
            Console.WriteLine($"4.feladat: Kérek egy vegyjelet: ");
            string bekert = Console.ReadLine();
            //6.feladat
            string vegyjel = "Sg";
            Console.WriteLine($"6. feladat: Keresés \n Az elem vegyjele {vegyjel} \n Az elem neve: {felfedezes.Where(x=>x.Vegyjel == vegyjel).Where(x=>x.Név)}\n AzRendszáma: {felfedezes.Where(x => x.Vegyjel == vegyjel).Where(x => x.Rendszam)}\n Felfedezés éve: {felfedezes.Where(x => x.Vegyjel == vegyjel).Where(x => x.Év)}\n Felfedező: {felfedezes.Where(x => x.Vegyjel == vegyjel).Where(x => x.Felfedezo)} ");
            //7.feladat
            Console.WriteLine($"{felfedezes.Where(x => x.Év).Max() - felfedezes.Where(x => x.Év).Min() } év volt a leghosszabb időszak két elem felfedezése között.");
            //8.feladat
            Console.WriteLine($"8. feladat: Statisztika \n {felfedezes.GroupBy(x=>x.Év).Where())}");

        }
    }
}
