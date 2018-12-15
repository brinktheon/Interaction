using System;
namespace DatabaseInteraction
{
    public static class QuerysConstants
    {
        // String connection
        public const string STRING_CONNECTION = 
            "Server=localhost;" +
            "Database=warehouse;" +
            "User ID=root;" +
            "Password=password;" +
            "Pooling=false";

        // Select All Records
        public const string SELECT_ALL_DEPARTURE = "SELECT * FROM Sending;";
        public const string SELECT_ALL_PRODUCER = "SELECT * FROM Producer";
        public const string SELECT_ALL_PRODUCT = "SELECT * FROM Product";
        public const string SELECT_ALL_PRODUCT_TYPE = "SELECT * FROM Type";
        public const string SELECT_ALL_PROVIDER = "SELECT * FROM Provider";
        public const string SELECT_ALL_STORE = "SELECT * FROM Store";
        public const string SELECT_ALL_WAREHOUSE = "SELECT * FROM Warehouse";
    }
}
