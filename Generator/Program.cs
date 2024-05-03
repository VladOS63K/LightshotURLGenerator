using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lightshot URL Generator";
            Console.WriteLine("Lightshot URL Generator\n");
            Console.Write("How many links do you want to generate >");
            int linksCount = int.Parse(Console.ReadLine());

            string urlChrs = "qwertyuiopasdfghjklzxcvbnm1234567890";
            List<string> listUrls = new List<string>();

            for (int i = 0;i<linksCount;i++)
            {
                char[] charMap = urlChrs.ToCharArray();
                Random rand = new Random();
                string output = "https://prntscr.com/";
                for (int ii = 0; ii<6;ii++)
                {
                    char randChar = charMap[rand.Next(0, charMap.Length)];
                    output += randChar;
                }
                listUrls.Add(output);
            }

            Console.WriteLine("\n\nYour URLs are:\n");

            foreach (string url in listUrls)
            {
                Console.WriteLine(url);
            }

            Console.WriteLine("\nClick any key to exit.");
            Console.ReadKey();
        }
    }
}
