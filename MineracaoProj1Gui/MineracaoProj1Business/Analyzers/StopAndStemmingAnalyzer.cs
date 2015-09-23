using Lucene.Net.Analysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business.Analyzers
{
    public class StopAndStemmingAnalyzer : StopwordsAnalyzer
    {
        public override TokenStream TokenStream(string fieldName, TextReader reader)
        {
            TokenStream result = base.TokenStream(fieldName, reader);
            return new PorterStemFilter(result);
        }
    }
}
