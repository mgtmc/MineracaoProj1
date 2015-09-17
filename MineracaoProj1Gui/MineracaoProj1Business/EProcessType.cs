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
        [Description("Com stopList")]
        WithStopList = 2,
        [Description("com stemming")]
        WithStemming = 3
    }
}
