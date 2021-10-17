using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sari
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\odev\odev.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Araç sayısını girini:");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Tasit tasit = new Tasit();
                Araba araba = new Araba();
                Console.Write("Araç numarasını giriniz:");
                tasit.Id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Araç markasını giriniz:");
                tasit.Marka = Console.ReadLine();
                Console.Write("Araç modelini giriniz:");
                tasit.Model = Console.ReadLine();
                Console.Write("Araç rengini giriniz:");
                tasit.Renk = Console.ReadLine();
                Console.Write("Araç motor gücünü giriniz:");
                araba.motor = Console.ReadLine();
                Console.Write("Araç kasa tipi giriniz:");
                araba.kasatipi = Console.ReadLine();
                sw.WriteLine(tasit.Id + "  -  " + tasit.Marka + "  -  " 
                    + tasit.Model + "  -  " + tasit.Renk + araba.kasatipi + "  -  " + araba.motor + "  -  ");
                Console.Clear();

            }
            sw.Close();
            Console.WriteLine("Veriler dosyaya aktarıldı.");
            Console.ReadKey();
        }
        public class Tasit
        {
            public int Id { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
        }
        public class Araba : Tasit
        {
            public string motor { get; set; }
            public string kasatipi { get; set; }

        }
    }
}
