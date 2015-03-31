﻿using Santase.Logic;
using Santase.Logic.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.ConsoleUI
{
    public static class Program
    {
        public static void Main()
        {
            ISantaseGame game = new SantaseGame();
            game.Start();
            Console.WriteLine("Game finished!");
            Console.WriteLine("{0} - {1}",
                game.FirstPlayerTotalPoints,
                game.SecondPlayerTotalPoints);
        }
    }
}
