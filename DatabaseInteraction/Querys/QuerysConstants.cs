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

        // Insert
        public const string ADD_WAREHOUS = "insert into Warehouse(address, employeeName) values('{0}', '{1}');";
        public const string ADD_PROVIDER = "insert into Provider (name) values ('{0}');";
        public const string ADD_PRODUCER = "insert into Producer (name) values ('{0}');";
        public const string ADD_DEPARTURE = "insert into Sending (dateSending, quantity, store_id, product_id) values ('{0}', {1}, {2}, {3});";
        public const string ADD_STORE = "insert into Store (name, address, warehouse_id) values ('{0}', '{1}', {2});";
        public const string ADD_TYPE = "insert into Type (name) values ('{0}');";
        public const string ADD_WAREHOUSE_PRODUCT = "insert into Warehouse_Product (warehouse_id, product_id) values ({0}, {1});";
        public const string ADD_PRODUCT = "insert into Product (name, price, quantity, receiptDate, status, produce_id, provider_id, type_id) values ('{0}', '{1}', {2}, '{3}', {4}, {5}, {6}, {7});";

        // Remove
        public const string REMOVE_WAREHOUSE = "delete from Warehouse where id = {0};";
        public const string REMOVE_PROVIDER = "delete from Provider where id = {0};";
        public const string REMOVE_PRODUCER = "delete from Producer where id = {0};";
        public const string REMOVE_DEPARTURE = "delete from Sending where id = {0};";
        public const string REMOVE_STORE = "delete from Store where id = {0};";
        public const string REMOVE_TYPE = "delete from Type where id = {0};";
        public const string REMOVE_WAREHOUSE_PRODUCT_BY_WAREHOUSE_ID = "delete from Warehouse_Product where warehouse_id = {0};";
        public const string REMOVE_WAREHOUSE_PRODUCT_BY_PRODUCT_ID = "delete from Warehouse_Product where product_id = {0};";
        public const string REMOVE_PRODUCT = "delete from Product where id = {0};";

        // Update
        public const string UPDATE_WAREHOUSE = "update Warehouse set address = '{0}', employeeName = '{1}'  where id = {2};";
        public const string UPDATE_PROVIDER = "update Provider set name = '{0}' where id = {1};";
        public const string UPDATE_PRODUCER = "update Producer set name = '{0}' where id = {1};";
        public const string UPDATE_DEPARTURE = "update Sending set dateSending = '{0}', quantity = {1}, store_id = {2}, product_id = {3} where id = {4};";
        public const string UPDATE_STORE = "update Store set name = '{0}', address = '{2}', warehouse_id = {3} where id = {4};";
        public const string UPDATE_TYPE = "update Type set name = '{0}' where id = {1};";
        public const string UPDATE_WAREHOUSE_PRODUCT_BY_PRODUCT_ID = "update Warehouse_Product set warehouse_id = {0} where product_id = {1};";
        public const string UPDATE_WAREHOUSE_PRODUCT_BY_WAREHOUSE_ID = "update Warehouse_Product set product_id = {0} where warehouse_id = {1};";
        public const string UPDATE_PRODUCT = "update Product " +
        	"set name = '{0}', price = '{1}', quantity = {2}, receiptDate = '{3}', status = {4}, produce_id = {5}, provider_id = {6}, type_id = {7} " +
        	"where id = {8};";


        // Select By ID
        public const string SELECT_PRODUCT_BY_WAREHOUSE_ID = "select * from Product as p " +
        	"inner join Warehouse_Product as wp " +
        	    "on wp.product_id = p.id " +
            "inner join Warehouse as w " +
        	    "on w.id = wp.warehouse_id " +
            "where w.id = {0};";
        // Возвращает все магазины данного продукта
        public const string SELECT_ALL_STORES_BY_PRODUCT_ID = "select p.id as productId, p.name as productName, p.price as productPrice, p.quantity as productQuantity, p.receiptDate as productReceiptDate, p.status, s.dateSending, s.quantity as sendingQuantity, st.name as storeName, st.address as storeAddress from Product as p " +
        	"inner join Sending as s " +
        	    "on p.id = s.product_id " +
        	"inner join Store as st " +
        	    "on st.id = s.store_id " +
        	"where p.id = {0};";
    }
}
