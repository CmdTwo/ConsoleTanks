using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Global.Constans.StartGame = DateTime.Now;

            Map.GlobalMap map = new Map.GlobalMap();
            map.DisplayMap();
            Console.ReadKey();
        }
    }
}
