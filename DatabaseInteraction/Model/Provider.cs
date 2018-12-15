using System;
namespace DatabaseInteraction
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }


        internal string GetInfo()
        {
            return $"Provider = {Name} - {Id}";
        }
    }
}
