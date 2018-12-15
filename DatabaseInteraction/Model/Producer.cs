using System;
namespace DatabaseInteraction
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }


        internal string GetInfo()
        {
            return $"Producer = {Name} - {Id}";
        }
    }
}
