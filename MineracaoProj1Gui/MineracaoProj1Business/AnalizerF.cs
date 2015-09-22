using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public static class AnalizerF
    {
        public static Analyzer Factory(string type)
        {
            if (type.Equals(EProcessType.WithStopList.GetDescription()))
                return new StopwordsAnalyzer();
            else if (type.Equals(EProcessType.WithStemming.GetDescription()))
                return new StemmingAnalyzer();
            else if (type.Equals(EProcessType.WithStopListAndStemming.GetDescription()))
                return new StopAndStemmingAnalyzer();
            else
                return new DefaultAnalyzer();
        }
    }
}
