using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.DTOS
{
    public class ColumnInfo
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public ColumnFormater Formater { get; set; }
        public string color { get; set; }
        public string BgColor { get; set; }

        public string OrderBy {get; set;}

        public ColumnInfo(string key)
        {
            Key = key;
        }
    }
}
