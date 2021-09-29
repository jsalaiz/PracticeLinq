using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoGameList = new List<string>()
            {
                "Zelda",
                "Minecraft",
                "Terrafria",
                "Skyrim",
                "Bioshock"
            };

            var videoGameListByLength = videoGameList.OrderBy(x => x.Length);
            Console.WriteLine(string.Join(", ", videoGameListByLength));
        }
    }
}
