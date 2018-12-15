using System;
namespace DatabaseInteraction
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        internal string GetInfo()
        {
            return $"Store =  {Id} - {Name} - {Address}";
        }
    }
}
