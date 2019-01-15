using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MacroRiver.Model
{
    public class FullColumns
    {
        public string Field { get; set; }
        public string Type { get; set; }
        public string Collation { get; set; }
        public string Null { get; set; }
        public string Key { get; set; }
        public string Default { get; set; }
        public string Extra { get; set; }
        public string Privileges { get; set; }
        public string Comment { get; set; }

    }
}
