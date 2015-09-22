using Lucene.Net.Analysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public class StopwordsAnalyzer : DefaultAnalyzer
    {
        public override TokenStream TokenStream(string fieldName, TextReader reader)
        {
            TokenStream result = base.TokenStream(fieldName, reader);
            result = new StopFilter(true, result, StopAnalyzer.ENGLISH_STOP_WORDS_SET);
            return result;
        }
    }
}
