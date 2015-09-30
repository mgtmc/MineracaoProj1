using Lucene.Net.Search;
using MineracaoProj1Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Program
    {
        static List<int> docs1 = new List<int> { 4, 2 };
        static List<int> docs2 = new List<int> { 88, 46, 98, 72 };
        static string query1 = "prophecies";
        static string query2 = "miracle"; 
        static void Main(string[] args)
        {
            Indexer indexer = new Indexer("Normal");
            if (System.Environment.MachineName.ToString().Equals("NINAHAACK"))
                indexer.IndexFiles(Constants.BASEPATHHAACK);
            else
                indexer.IndexFiles(Constants.BASEPATH);
            indexer.Close();

            MineracaoProj1Business.Searcher searcher = new MineracaoProj1Business.Searcher("Normal");
            TopDocs hits = searcher.Search(query1);
            Medidas med = new Medidas(hits, searcher, docs1);
            Console.WriteLine("Precisao = " + med.precisao);
            Console.WriteLine("Cobertura = " + med.cobetura);
            Console.WriteLine("FMeasure = " + med.fmeasure);
        }
    }
}
