using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubLib.Bll;

namespace Sub
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("= Subtitle HTML Tag remover =");
            Console.WriteLine(@"Sample: Sub SourceFilePath TargetFilePath");
            Console.WriteLine();


            SubEngine engine = new SubEngine();

            var fileContent = engine.LoadSrtFile(@"d:\The.Accountant.2016.BDRip.x264-SPARKS + YTS.AG.srt");
            engine.StripHtml(fileContent);
            var rest = engine.SaveFile(fileContent, @"d:\abc.txt");

            Console.Write("Enter any key to exit:");
            Console.ReadKey();
        }
    }
}
