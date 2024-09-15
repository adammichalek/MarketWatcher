namespace MarketWatcherAPI.Repositories
{
    public class MarketWatcherDbConnectionString
    {
        private readonly string _connectionString;

        public MarketWatcherDbConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static implicit operator string(MarketWatcherDbConnectionString connectionString)
        {
            return connectionString._connectionString;
        }
    }
}
