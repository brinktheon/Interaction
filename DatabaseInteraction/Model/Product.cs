using System;
namespace DatabaseInteraction
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string ReceiptDate { get; set; }
        public bool Status { get; set; }



        internal string GetInfo()
        {
            return "Product:" +
            	$"\nName = {Name}" +
                $"\nPrice = {Price}" +
                $"\nQuantity = {Quantity}" +
                $"\nReceiptDate = {ReceiptDate}" +
                $"\nStatus = {Status}" + 
                $"\nId = {Id}";
        }
    }
}
