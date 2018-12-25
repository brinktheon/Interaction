using System;
using System.Collections.Generic;

namespace DatabaseInteraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<ProductStore>();
            ImplRepository<ProductStore> repository = 
                    new ImplRepository<ProductStore>(QuerysConstants.STRING_CONNECTION);
            list = repository.ExecuteQuery(String.Format(QuerysConstants.SELECT_ALL_STORES_BY_PRODUCT_ID, 1));

            foreach (var val in list)
            {
                Console.WriteLine("{0}\n____________________", val.GetInfo());
            }
        }
    }
}
