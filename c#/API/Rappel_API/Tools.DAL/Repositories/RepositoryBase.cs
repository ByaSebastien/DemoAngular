using System.Data;

namespace DAL
{
    public abstract class RepositoryBase<TId, TEntity> : IRepository<TId, TEntity> where TEntity : class, IEntity<TId>
    {
        protected IDbConnection _Connection;
        public string TableName { get; init; }
        public string ColumnIdName { get; init; }

        public RepositoryBase(IDbConnection connection, string tableName, string columnIdName)
        {
            _Connection = connection;
            TableName = tableName;
            ColumnIdName = columnIdName;
        }

        protected void GenerateParameter(IDbCommand command, string name, object data)
        {
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = data ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }

        protected abstract TEntity Convert(IDataRecord dataRecord);


        #region CRUD
        public abstract TId Insert(TEntity entity);

        public virtual IEnumerable<TEntity> GetAll()
        {
            using (IDbCommand command = _Connection.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {TableName}";
                _Connection.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return Convert(reader);
                    }
                }
                _Connection.Close();
            }
        }

        public virtual TEntity GetById(TId id)
        {
            using (IDbCommand command = _Connection.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {TableName} WHERE {ColumnIdName} = @Id";
                _Connection.Open();
                GenerateParameter(command, "id", id);
                using (IDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return Convert(reader);
                    throw new ArgumentNullException($"{TableName} Inexistant");
                }
            }
        }

        public abstract bool Update(TId id,TEntity entity);

        public virtual bool Delete(TId id)
        {
            using (IDbCommand command = _Connection.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {TableName} WHERE {ColumnIdName} = @Id";
                GenerateParameter(command, "@Id", id);
                _Connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }
        #endregion
    }
}

