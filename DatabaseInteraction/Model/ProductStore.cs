using System;
namespace DatabaseInteraction
{
    public class ProductStore
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductReceiptDate { get; set; }
        public bool Status { get; set; }
        public string DateSending { get; set; }
        public string SendingQuantity { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }

        internal string GetInfo()
        {
            return "Product:" +
                $"\nProductName = {ProductName}" +
                $"\nProductPrice = {ProductPrice}" +
                $"\nProductQuantity = {ProductQuantity}" +
                $"\nProductReceiptDate = {ProductReceiptDate}" +
                $"\nStatus = {Status}" +
                $"\nProductId = {ProductId}" +
                $"\nDateSending = {DateSending}" +
                $"\nSendingQuantity = {SendingQuantity}" +
                $"\nStoreName = {StoreName}" +
                $"\nStoreAddress = {StoreAddress}"
                ;
        }
    }
}
