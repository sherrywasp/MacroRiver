namespace MacroRiver.Model
{
    public class ColumnMapping
    {
        public int ColIndex { get; set; }
        public string ExcelColName { get; set; }
        public string DbColName { get; set; }
        public string ColDataType { get; set; }

        public bool NeedSingleQuotes { get; }

        public ColumnMapping() { }

        public ColumnMapping(int colIndex, string excelColName, string dbColName, string colDataType)
        {
            this.ColIndex = colIndex;
            this.ExcelColName = excelColName;
            this.DbColName = dbColName;
            this.ColDataType = colDataType;
            if(colDataType == "char" ||
                colDataType == "nchar" ||
                colDataType == "varchar" ||
                colDataType == "nvarchar" ||
                colDataType == "text" ||
                colDataType == "mediumtext" ||
                colDataType == "longtext" ||
                colDataType == "date" ||
                colDataType == "time" ||
                colDataType == "datetime" ||
                colDataType == "timestamp")
            {
                this.NeedSingleQuotes = true;
            }
            else
            {
                this.NeedSingleQuotes = false;
            }
        }
    }
}
