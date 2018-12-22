using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DatabaseInteraction
{
    public abstract class BaseRepository<T> where T : new()
    {
        protected MySqlConnection connection;
        protected MySqlCommand cmd;
        protected MySqlDataReader reader;
        protected string stringConnection;

        protected BaseRepository(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public void OpenConnection(string stringConnection)
        {
            try
            {
                connection = new MySqlConnection
                {
                    ConnectionString = stringConnection
                };
                connection.Open();

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public virtual List<T> ExecuteQuery(string sql)
        {
            OpenConnection(stringConnection);

            var localListObjects = new List<T>();
            try
            {
                cmd = new MySqlCommand(sql, connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    localListObjects.Add(Serialize(reader));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
                CloseConnection();
            }
            return localListObjects;
        }

        public virtual T Serialize(MySqlDataReader reader)
        {
            var results = default(T);

            var item = TypeOfEntity(reader);
            foreach (var property in item.GetType().GetProperties())
            {
                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                {
                    Type convertTo = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                    if (convertTo.IsEnum)
                    {
                        property.SetValue(item, Enum.Parse(convertTo, reader[property.Name].ToString()), null);
                    }
                    else
                        property.SetValue(item, Convert.ChangeType(reader[property.Name], convertTo), null);
                }
            }
            results = item;

            return results;
        }

        public virtual T TypeOfEntity(MySqlDataReader reader)
        {
            return new T();
        }

    }
}
