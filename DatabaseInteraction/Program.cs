using System;
using System.Collections.Generic;

namespace DatabaseInteraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<Product>();
            ImplRepository<Product> repository = 
                    new ImplRepository<Product>(QuerysConstants.STRING_CONNECTION);
            list = repository.Load(String.Format(QuerysConstants.SELECT_PRODUCT_BY_WAREHOUSE_ID, 1));

            foreach (var val in list)
            {
                Console.WriteLine("{0}\n____________________", val.GetInfo());
            }
        }
    }
}
