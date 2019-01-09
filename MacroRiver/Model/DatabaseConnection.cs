using Dapper.Contrib.Extensions;

namespace MacroRiver.Model
{
    [Table("db_connection")]
    public class DatabaseConnection
    {
        [ExplicitKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Hostname { get; set; }
        public int? Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
