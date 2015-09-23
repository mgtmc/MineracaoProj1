﻿using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using MineracaoProj1Business.Analyzers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public class Searcher
    {
        public IndexSearcher IndexSearcher { get; set; }
        public QueryParser QueryParser { get; set; }
        public Query Query { get; set; }

        public Searcher(string type)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Constants.INDEX);
            Lucene.Net.Store.Directory directory = FSDirectory.Open(directoryInfo);
            Analyzer analyzer = AnalyzerFactory.Factory(type);

            this.QueryParser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, Constants.CONTENTS, analyzer);
            this.IndexSearcher = new IndexSearcher(directory);
        }

        public TopDocs Search(string searchQuery)
        {
            this.Query = QueryParser.Parse(searchQuery);

            return this.IndexSearcher.Search(this.Query, Constants.MAX_SEARCH);
        }

        public Document GetDocument(ScoreDoc scoreDoc)
        {
            return this.IndexSearcher.Doc(scoreDoc.Doc);
        }

        public void Close()
        {
            this.IndexSearcher.Dispose();
        }
    }
}
