using Lucene.Net.Documents;
using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{

    public class Medidas
    {
        public int qtdDocsRelevantesRetornados { get; set; }
        public double precisao { get; set; }
        public double cobetura { get; set; }
        public double fmeasure { get; set; }

        public Medidas(TopDocs hits, Searcher searcher, List<int> docs)
        {
            this.qtdDocsRelevantesRetornados = DocsRelevantesRecuperados(hits, searcher, docs);
            this.precisao = _Precisao(hits.ScoreDocs.Length);
            this.cobetura = _Cobertura(docs.Count);
            this.fmeasure = _FMeasure();
        }

        private int DocsRelevantesRecuperados(TopDocs hits, Searcher searcher, List<int> docs)
        {
            int qtd = 0;

            foreach (ScoreDoc scoreDoc in hits.ScoreDocs)
            {
                Document doc = searcher.GetDocument(scoreDoc);
                string docId = doc.Get(Constants.FILE_NAME);
                string number = docId.Substring(docId.IndexOf('(')+1, docId.IndexOf(')') - docId.IndexOf('(') - 1);
                int num = Int32.Parse(number);
                
                if (docs.Contains(num))
                    qtd++;
            }

            return qtd;
        }

        private double _Precisao(int docsRec)
        {
            return (double) qtdDocsRelevantesRetornados / docsRec;
        }

        private double _Cobertura(int docsRel)
        {
            return (double) qtdDocsRelevantesRetornados / docsRel;
        }

        private double _FMeasure()
        {
            double numerador = 2 * precisao * cobetura;
            double denominador = precisao + cobetura;

            return numerador / denominador;
        }
    }
}
