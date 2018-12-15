using System;
using MySql.Data.MySqlClient;

namespace DatabaseInteraction
{
    public class ImplRepository<T> : BaseRepository<T> where T : new()
    {
        public ImplRepository(string stringConnection) : base(stringConnection)
        {
        }

        public override T TypeOfEntity(MySqlDataReader reader)
        {
            return base.TypeOfEntity(reader);
        }
    }
}
