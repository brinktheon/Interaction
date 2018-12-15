using System;
using System.Collections.Generic;

namespace DatabaseInteraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<Warehouse>();
            ImplRepository<Warehouse> repository = 
                    new ImplRepository<Warehouse>(QuerysConstants.STRING_CONNECTION);
            list = repository.Load(QuerysConstants.SELECT_ALL_WAREHOUSE);

            foreach (var val in list)
            {
                Console.WriteLine("{0}\n____________________", val.GetInfo());
            }
        }
    }
}
