using System;
namespace DatabaseInteraction
{
    public class ProductType
    {
        public ProductType()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }


        internal string GetInfo()
        {
            return $"ProductType = {Name} - {Id}";
        }
    }
}
