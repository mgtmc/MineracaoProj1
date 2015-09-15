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
        string dataDir = @"C:\Users\Nina\Desktop\Nova pasta\a";
        Indexer indexer;
        MineracaoProj1Business.Searcher searcher;


        static void Main(string[] args)
        {
            Testee tester = new Testee();
            tester.createIndex();
            tester.search("concession");
            Console.WriteLine("");
        }

        private void createIndex()
        {
            this.indexer = new Indexer();
            int numIndexed;
            numIndexed = indexer.CreateIndex(this.dataDir);
        }

        private void search(String searchQuery)
        {
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
