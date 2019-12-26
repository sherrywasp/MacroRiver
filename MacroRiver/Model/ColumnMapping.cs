namespace MacroRiver.Model
{
    public class ColumnMapping
    {
        public int ColIndex { get; set; }
        public string ExcelColName { get; set; }
        public InformationSchemaColumns DbColInfo { get; set; }        
        public bool NeedSingleQuotes { get; }

        public ColumnMapping() { }

        public ColumnMapping(int colIndex, string excelColName, InformationSchemaColumns dbColInfo)
        {
            this.ColIndex = colIndex;
            this.ExcelColName = excelColName;
            this.DbColInfo = dbColInfo;
            if (dbColInfo.DATA_TYPE == "char" ||
                dbColInfo.DATA_TYPE == "nchar" ||
                dbColInfo.DATA_TYPE == "varchar" ||
                dbColInfo.DATA_TYPE == "nvarchar" ||
                dbColInfo.DATA_TYPE == "text" ||
                dbColInfo.DATA_TYPE == "mediumtext" ||
                dbColInfo.DATA_TYPE == "longtext" ||
                dbColInfo.DATA_TYPE == "date" ||
                dbColInfo.DATA_TYPE == "time" ||
                dbColInfo.DATA_TYPE == "datetime" ||
                dbColInfo.DATA_TYPE == "timestamp")
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
