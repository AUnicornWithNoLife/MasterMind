﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Mind
{
    public class Menu
    {
        private static ConsoleKey[] inputKeys =
        {
            ConsoleKey.D1,
            ConsoleKey.D2,
            ConsoleKey.D3,
            ConsoleKey.D4,
            ConsoleKey.D5,
            ConsoleKey.D6,
            ConsoleKey.D7,
            ConsoleKey.D8,
            ConsoleKey.D9,
        };

        public static int NumberMenu(string[] menuItems, string inputPrompt = "", ConsoleKey? menuReturn = null)
        {
            int width = 0;

            foreach (string menuItem in menuItems)
            {
                if (menuItem.Length > width)
                    width = menuItem.Length;
            }

            for (int i = 1; i <= menuItems.Length; i++)
            {
                int expanse = (width - menuItems[i - 1].Length) + 1;

                Console.WriteLine("[ " + i.ToString() + ":  " + menuItems[i - 1] + String.Concat(Enumerable.Repeat(" ", expanse)) + "]");
            }

            Console.WriteLine();

            if (menuReturn != null)
            {
                Console.WriteLine("Press [" + menuReturn.ToString() + "] to go back");
                Console.WriteLine();
            }

            Console.Write((inputPrompt == "") ? "Option: " : inputPrompt);

            while (true)
            {
                ConsoleKey input = Console.ReadKey().Key;

                if (input == menuReturn)
                    return -1;

                for (int i = 1; i <= menuItems.Length; i++)
                {
                    if (input == inputKeys[i - 1])
                        return i;
                }
            }
        }

        public static int ChooseNumber(int min = 0, int max = 0)
        {
            if (max <= 0)
                max = 10;

            if (min == 0)
                min = 1;

            while (true)
            {
                ConsoleKey input = Console.ReadKey().Key;

                for (int i = min; i < max; i++)
                {
                    if (input == inputKeys[i - 1])
                        return i;
                }
            }
        }

        public static int ChooseOption(ConsoleKey[] options)
        {
            while (true)
            {
                ConsoleKey input = Console.ReadKey().Key;

                for (int i = 0; i < options.Length; i++)
                {
                    if (input == inputKeys[i])
                        return i;
                }
            }
        }
    }
}
