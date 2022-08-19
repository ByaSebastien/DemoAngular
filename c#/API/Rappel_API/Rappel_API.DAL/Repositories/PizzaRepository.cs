using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PizzaRepository : RepositoryBase<int, Pizza>, IPizzaRepository
    {

        public PizzaRepository(IDbConnection connection) : base(connection,"V_Pizza","Id"){}

        public override int Insert(Pizza entity)
        {
            using (IDbCommand command = _Connection.CreateCommand())
            {
                command.CommandText = "SP_Pizza_Insert";
                command.CommandType = CommandType.StoredProcedure;
                GenerateParameter(command, "@Name", entity.Name);
                GenerateParameter(command, "@Price", entity.Price);
                GenerateParameter(command, "@PizzaType", entity.PizzaType);
                _Connection.Open();
                return (int)command.ExecuteScalar()!;
            }
        }

        protected override Pizza Convert(IDataRecord dataRecord)
        {
            return new Pizza
            {
                Id = (int)dataRecord["Id"],
                Name = (string)dataRecord["Name"],
                PizzaType = (string)dataRecord["PizzaType"],
                Price = (decimal)dataRecord["Price"]
            };
        }

        public override bool Delete(int id)
        {
            using (IDbCommand command = _Connection.CreateCommand())
            {
                command.CommandText = "SP_Pizza_Delete";
                command.CommandType = CommandType.StoredProcedure;
                GenerateParameter(command, "@Id", id);

                _Connection.Open();
                return command.ExecuteNonQuery() == 1;
            }
        }

        public override bool Update(int id, Pizza entity)
        {
            throw new NotImplementedException();
        }
    }
}
