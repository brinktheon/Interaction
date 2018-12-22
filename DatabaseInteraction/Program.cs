using System;
using System.Collections.Generic;

namespace DatabaseInteraction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = new List<Provider>();
            ImplRepository<Provider> repository = 
                    new ImplRepository<Provider>(QuerysConstants.STRING_CONNECTION);
            list = repository.ExecuteQuery(String.Format(QuerysConstants.UPDATE_PROVIDER, "McDonald", 7));

            foreach (var val in list)
            {
                Console.WriteLine("{0}\n____________________", val.GetInfo());
            }
        }
    }
}
