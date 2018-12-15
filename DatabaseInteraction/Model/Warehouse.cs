using System;
namespace DatabaseInteraction
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string EmployeeName { get; set; }

        internal string GetInfo()
        {
            return $"Warehouse =  {Id} - {Address} - {EmployeeName}";
        }
    }
}
