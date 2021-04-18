using System;
using System.Collections.Generic;
using System.IO;

namespace SymbolFrequencyCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 1)
            {
                Console.WriteLine("Неверное количество аргументов! Ожидается 1(путь к входному файлу)");
                return;
            }

            string inputText = File.ReadAllText(args[0]);

            var counterMap = new Dictionary<string, int>();

            foreach (var character in inputText)
            {
                var normalized = character.ToString().ToLower();
                
                if (counterMap.ContainsKey(normalized))
                {
                    counterMap[normalized]++;
                }
                else
                {
                    counterMap.Add(normalized, 1);
                }
            }

            foreach (var (character, count) in counterMap)
            {
                Console.WriteLine($"Символ \"{character}\" повторяется {count} раз.");
            }
            
        }
    }
}