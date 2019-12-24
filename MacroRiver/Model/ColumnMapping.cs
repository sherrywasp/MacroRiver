using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacroRiver.Model
{
    public class ColumnMapping
    {
        public string ExcelColName { get; set; }
        public string DbColName { get; set; }
        public string ColDataType { get; set; }
    }
}
