namespace MacroRiver.Model
{
    public class ColumnMapping
    {
        public string ExcelColName { get; set; }
        public string DbColName { get; set; }
        public string ColDataType { get; set; }

        public ColumnMapping() { }

        public ColumnMapping(string excelColName, string dbColName, string colDataType)
        {
            this.ExcelColName = excelColName;
            this.DbColName = dbColName;
            this.ColDataType = colDataType;
        }
    }
}
