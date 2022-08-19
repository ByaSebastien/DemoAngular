using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierRepository : ISupplierRepository
    {
        private IDbConnection _Connection;

        private string _ConnectionString = "Server=TFNSDOTDE0401B; Database=Northwind; Trusted_Connection=True;";

        public SupplierRepository()
        {
            _Connection = new SqlConnection(_ConnectionString);
        }

        private void GenerateParameter(IDbCommand command, string name, object data)
        {
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = data ?? DBNull.Value;
            command.Parameters.Add(parameter);
        }

        public int Add(Supplier supplier)
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "INSERT INTO Suppliers ([CompanyName],[ContactName],[ContactTitle],[Address],[City],[Region],[PostalCode],    [Country],[Phone],[Fax],[HomePage],[CountriesID])" +
                                  "OUTPUT inserted.[SupplierID]" +
                                  "VALUES(@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@PostalCode,@Country,@Phone,@Fax,@HomePage,@CountriesID)";
            GenerateParameter(command, "@CompanyName", supplier.CompanyName);
            GenerateParameter(command, "@ContactName", supplier.ContactName);
            GenerateParameter(command, "@ContactTitle", supplier.ContactTitle);
            GenerateParameter(command, "@Address", supplier.Address);
            GenerateParameter(command, "@City", supplier.City);
            GenerateParameter(command, "@Region", supplier.Region);
            GenerateParameter(command, "@PostalCode", supplier.PostalCode);
            GenerateParameter(command, "@Country", supplier.Country);
            GenerateParameter(command, "@Phone", supplier.Phone);
            GenerateParameter(command, "@Fax", supplier.Fax);
            GenerateParameter(command, "@HomePage", supplier.HomePage);
            GenerateParameter(command, "@CountriesID", supplier.CountriesID);

            _Connection.Open();
            int result = (int)command.ExecuteScalar();
            _Connection.Close();
            return result;
        }

        public bool Delete(int id)
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "DELETE FROM Suppliers WHERE SupplierID = @ID ";
            GenerateParameter(command, "@ID", id);
            _Connection.Open();
            bool result = command.ExecuteNonQuery() != 0;
            _Connection.Close();
            return result;
        }

        public IEnumerable<Supplier> GetAll()
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "SELECT * FROM Suppliers";
            _Connection.Open();
            SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
            ICollection<Supplier> result = new List<Supplier>();
            while (reader.Read())
            {
                Supplier supplier = new Supplier
                {
                    Id = (int)reader["SupplierID"],
                    CompanyName = (string)reader["CompanyName"],
                    ContactName = reader["ContactName"] == DBNull.Value ? null :(string)reader["ContactName"],
                    ContactTitle = reader["ContactTitle"] == DBNull.Value ? null : (string)reader["ContactTitle"],
                    Address = reader["Address"] == DBNull.Value ? null : (string)reader["Address"],
                    City = reader["City"] == DBNull.Value ? null : (string)reader["City"],
                    Region = reader["Region"] == DBNull.Value ? null : (string)reader["Region"],
                    PostalCode = reader["PostalCode"] == DBNull.Value ? null : (string)reader["PostalCode"],
                    Country = reader["Country"] == DBNull.Value ? null : (string)reader["Country"],
                    Phone = reader["Phone"] == DBNull.Value ? null : (string)reader["Phone"],
                    Fax = reader["Fax"] == DBNull.Value ? null : (string)reader["Fax"],
                    HomePage = reader["HomePage"] == DBNull.Value ? null : (string)reader["HomePage"],
                    CountriesID = reader["CountriesID"] == DBNull.Value ? null : (int)reader["CountriesID"]
                };
                result.Add(supplier);
            }
            _Connection.Close();
            return result;
        }

        public Supplier GetById(int id)
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "SELECT * FROM Suppliers";
            _Connection.Open();
            SqlDataReader reader = (SqlDataReader)command.ExecuteReader();
            while (reader.Read())
            {
                Supplier supplier = new Supplier
                {
                    Id = (int)reader["SupplierID"],
                    CompanyName = (string)reader["CompanyName"],
                    ContactName = reader["ContactName"] == DBNull.Value ? null : (string)reader["ContactName"],
                    ContactTitle = reader["ContactTitle"] == DBNull.Value ? null : (string)reader["ContactTitle"],
                    Address = reader["Address"] == DBNull.Value ? null : (string)reader["Address"],
                    City = reader["City"] == DBNull.Value ? null : (string)reader["City"],
                    Region = reader["Region"] == DBNull.Value ? null : (string)reader["Region"],
                    PostalCode = reader["PostalCode"] == DBNull.Value ? null : (string)reader["PostalCode"],
                    Country = reader["Country"] == DBNull.Value ? null : (string)reader["Country"],
                    Phone = reader["Phone"] == DBNull.Value ? null : (string)reader["Phone"],
                    Fax = reader["Fax"] == DBNull.Value ? null : (string)reader["Fax"],
                    HomePage = reader["HomePage"] == DBNull.Value ? null : (string)reader["HomePage"],
                    CountriesID = reader["CountriesID"] == DBNull.Value ? null : (int)reader["CountriesID"]
                };
                return supplier;
            }
            throw new Exception("Not Find");
        }

        public bool Update(Supplier supplier)
        {
            IDbCommand command = _Connection.CreateCommand();
            command.CommandText = "UPDATE Suppliers " +
                                  "SET CompanyName = @CompanyName, " +
                                  "ContactName = @ContactName, " +
                                  "ContactTitle = @ContactTitle, " +
                                  "Address = @Address, " +
                                  "City = @City, " +
                                  "Region = @Region, " +
                                  "PostalCode = @PostalCode, " +
                                  "Country = @Country, " +
                                  "Phone = @Phone, " +
                                  "Fax = @Fax, " +
                                  "HomePage = @HomePage, " +
                                  "CountriesID = @CountriesID " +
                                  "WHERE SupplierID = @ID ";
            GenerateParameter(command, "@ID", supplier.Id);
            GenerateParameter(command, "@CompanyName", supplier.CompanyName);
            GenerateParameter(command, "@ContactName", supplier.ContactName);
            GenerateParameter(command, "@ContactTitle", supplier.ContactTitle);
            GenerateParameter(command, "@Address", supplier.Address);
            GenerateParameter(command, "@City", supplier.City);
            GenerateParameter(command, "@Region", supplier.Region);
            GenerateParameter(command, "@PostalCode", supplier.PostalCode);
            GenerateParameter(command, "@Country", supplier.Country);
            GenerateParameter(command, "@Phone", supplier.Phone);
            GenerateParameter(command, "@Fax", supplier.Fax);
            GenerateParameter(command, "@HomePage", supplier.HomePage);
            GenerateParameter(command, "@CountriesID", supplier.CountriesID);
            _Connection.Open();
            bool result = command.ExecuteNonQuery() != 0;//
            _Connection.Close();
            return result;
        }
    }
}
