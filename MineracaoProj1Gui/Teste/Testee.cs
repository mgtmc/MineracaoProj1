using Lucene.Net.Documents;
using Lucene.Net.Search;
using MineracaoProj1Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste
{
   public class Testee
    {
        string dataDirectory = @"C:\Users\Nina\Desktop\Nova pasta\a";
        Indexer indexer;
        MineracaoProj1Business.Searcher searcher;


        static void Main(string[] args)
        {
            Testee tester = new Testee();
            tester._IndexAll();
            tester.search("concession");
            Console.WriteLine("");
        }

        private void _IndexAll()
        {
            // NumIndexed a quantidade de arquivos indexados
            this.indexer = new Indexer();
            int numIndexed;
            numIndexed = indexer.IndexFiles(this.dataDirectory);
            this.indexer.Close();
        }

        private void search(String searchQuery)
        {
            // hits.totalHits a quantidade de arquivos achados
            this.searcher = new MineracaoProj1Business.Searcher();
            TopDocs hits = this.searcher.Search(searchQuery);

            foreach (ScoreDoc scoreDoc in hits.ScoreDocs)
            {
                Document doc = this.searcher.GetDocument(scoreDoc);
                Console.WriteLine(doc.Get(Constants.FILE_PATH));
            }
        }

    }
}
