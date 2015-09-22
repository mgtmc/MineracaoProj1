using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineracaoProj1Business
{
    public enum EProcessType
    {
        [Description("Normal")]
        Normal = 1,
        [Description("Com stoplist")]
        WithStopList = 2,
        [Description("Com stemming")]
        WithStemming = 3,
        [Description("Stoplist e  stemming")]
        WithStopListAndStemming = 4
    }
}
