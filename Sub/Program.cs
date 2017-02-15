using System;
using System.Collections.Generic;
using System.IO;
using SubLib.Bll;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {
            StartApp();

            var list = GetListByArgs(args);

            var engine = new SubEngine();
            foreach (var key in list.Keys)
            {
                try
                {
                    var fileContent = engine.LoadSrtFile(key);
                    engine.StripHtml(fileContent);
                    engine.SaveFile(fileContent, list[key]);
                    Console.WriteLine($"HTML tags were removed for {key}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Convert error for {key}");
                    Console.WriteLine(ex.Message);
                }
            }

            ExitApp();
        }

        private static void StartApp()
        {
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine("======= Sub Cleaner  Version:0.0.0.1      =======");
            Console.WriteLine("=======                                   =======");
            Console.WriteLine("======= Author: Winston Wang              =======");
            Console.WriteLine("=======                                   =======");
            Console.WriteLine(@"Command: Sub.exe SourceFilePath TargetFilePath");
            Console.WriteLine("=================================================");
            Console.WriteLine();
        }

        private static void ExitApp()
        {
            Console.WriteLine();
            Console.Write("Enter any key to exit:");
            Console.ReadKey();
        }

        private static Dictionary<string, string> GetListByArgs(string[] args)
        {
            var list = new Dictionary<string, string>();
            if (args.Length == 0)
            {
                var sources = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.srt");
                foreach (var sour in sources)
                {
                    if (!sour.EndsWith("_1.srt"))
                        list.Add(sour, sour.ToLower().Replace(".srt", "_1.srt"));
                }
            }
            else
            {
                var source = Directory.GetFiles(Directory.GetCurrentDirectory(), args[0]);
                var target = source;
                if (args.Length > 1)
                {
                    target = Directory.GetFiles(Directory.GetCurrentDirectory(), args[1]);
                }
                list.Add(source[0], target[0]);
            }
            return list;
        }
    }
}
