using System;
using System.Collections.Generic;
using System.Threading;

namespace M3uEditor
{
    internal class M3uApplication
    {
        public const string FolderName = @"C:\Users\matsd\OneDrive\Desktop\m3u\";
        private Link _link = new Link();
        private M3UCollection _m3ucollection = new M3UCollection();

        private readonly bool loop = true;
        public M3uApplication()
        {
            while (loop)
            {
                PrintHeader(_m3ucollection.links.Count);
                loop = HandleMenuOptions(loop);
            }
        }
        private bool HandleMenuOptions(bool loop)
        {
            Console.Write("Val: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (input.Equals("1"))
            {
                string fileName = string.Empty;
                foreach (var item in _m3ucollection.GetFileName())
                {
                    if (item.Substring(item.Length - 4).Equals(".m3u"))
                    {
                        _m3ucollection.AddFileData(item);
                        for (int i = 0; i < _m3ucollection.linksRaw.Count; i = i + 2)
                        {
                            _m3ucollection.links.Add(
                                new Link
                                {
                                    Info = _m3ucollection.linksRaw[i].Line,
                                    HttpLink = _m3ucollection.linksRaw[i + 1].Line,
                                }
                                );
                        }
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("Återgå till menyn? [Enter]");
                Console.ReadLine();
            }
            if (input.Equals("2"))
            {
                string fileName = string.Empty;
                foreach (var item in _m3ucollection.GetFileName())
                {
                    if (item.Substring(item.Length - 4).Equals(".txt"))
                    {
                        _m3ucollection.AddFilterData(item);
                    }
                }
                _m3ucollection.Filter(_m3ucollection.filter);

                Console.WriteLine("Återgå till menyn? [Enter]");
                Console.ReadLine();
            }

            if (input.Equals("3"))
            {
                _m3ucollection.CreateM3U();
                Console.WriteLine("Återgå till menyn? [Enter]");
                Console.ReadLine();

            }


            if (input.Equals("0"))
            {
                loop = false;
            }
            return loop;
        }

        static void PrintHeader(int nodes)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("M3U Editor \t|\t " + DateTime.Now.AddDays(0).ToString("yyyy-MM-dd HH:mm:ss") + " \t|\t Listans längd: " + nodes);
            Console.WriteLine("______________________________________________________________________________________________________________");
            Console.WriteLine("Importera M3U[1]  Filtrera[2] Skapa M3U[3] Quit[0]");
            Console.WriteLine();

        }
    }
}