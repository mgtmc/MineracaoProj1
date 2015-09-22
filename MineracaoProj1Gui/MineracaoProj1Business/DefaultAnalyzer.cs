using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public class DefaultAnalyzer : Analyzer
    {
        public override TokenStream TokenStream(string fieldName, TextReader reader)
        {
            TokenStream result = new LowerCaseTokenizer(reader);
            result = new StandardFilter(result);
            return result;
        }
    }
}
