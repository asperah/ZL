using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool progrun = true;
            int wahl;
            int kforwards = 3;
            int kbackwards = 19;
            Zirkulator zl = new Zirkulator();
            while (progrun)
            {
                zl.ShowValues();
                Console.WriteLine("Möchtest du Vorwärts (1) oder Rückwärts (2) gehen? Oder möchtest du das Programm beenden? (3)");
                wahl = Convert.ToInt32(Console.ReadLine());
                if (wahl == 1)
                {
                    Console.WriteLine("Wie viele Schritte möchtest du Vorwärts gehen?");
                    kforwards=Convert.ToInt32(Console.ReadLine());
                    zl.current = zl.SkipXForward(zl.current, kforwards);
                    Console.WriteLine("Neue Position: " + zl.current.Value);
                }
                if (wahl == 3)
                {
                    progrun = false;
                }
                if (wahl == 2)
                {
                    Console.WriteLine("Wie viele Schritte möchtest du Rückwärts gehen?");
                    kbackwards = Convert.ToInt32(Console.ReadLine());
                    zl.current = zl.SkipXBackward(zl.current, kbackwards);
                    Console.WriteLine("Neue Position: " + zl.current.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
