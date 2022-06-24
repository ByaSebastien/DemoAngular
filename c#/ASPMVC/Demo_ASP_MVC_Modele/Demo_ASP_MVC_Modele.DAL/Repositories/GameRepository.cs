using Demo_ASP_MVC_Modele.DAL.Entities;
using Demo_ASP_MVC_Modele.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASP_MVC_Modele.DAL.Repositories
{
    public class GameRepository : IGameRepository
    {
        private IDbConnection _Connection;

        public GameRepository(IDbConnection connection)
        {
            _Connection = connection;
        }

        private void GenerateParameter(IDbCommand command, string name, object data)
        {
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = data ?? DBNull.Value; 
            command.Parameters.Add(parameter);
        }
        #region CRUD
        public int Add(GameEntity entity)
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "INSERT INTO Game ([Name],[Description],[Nb_Player_min],[Nb_Player_Max],[Age],[Coop])" +
                                  "OUTPUT inserted.[Id]" +
                                  "VALUES(@Name,@Desc,@NbPlayerMin,@NbPlayerMax,@Age,@Coop)";
            GenerateParameter(command, "@Name", entity.Name);
            GenerateParameter(command, "@Desc", entity.Description);
            GenerateParameter(command, "@NbPlayerMin", entity.Nb_Player_Min);
            GenerateParameter(command, "@NbPlayerMax", entity.Nb_Player_Max);
            GenerateParameter(command, "@Age", entity.Age);
            GenerateParameter(command, "@Coop", entity.IsCoop);

            _Connection.Open();
            int result = (int)command.ExecuteScalar();
            _Connection.Close();
            return result;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public GameEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(GameEntity entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
