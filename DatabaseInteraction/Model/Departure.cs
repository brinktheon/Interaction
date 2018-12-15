using System;
namespace DatabaseInteraction
{
    public class Departure
    {
        public int Id { get; set; }
        public string DateSending { get; set; }
        public string Quantity { get; set; }

        internal string GetInfo()
        {
            return "Departure:" +
               $"\nDateSending = {DateSending}" +
               $"\nQuantity = {Quantity}" +
               $"\nId = {Id}";
        }
    }
}
