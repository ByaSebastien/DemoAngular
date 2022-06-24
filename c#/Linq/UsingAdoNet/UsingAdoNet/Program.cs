using System.Data.SqlClient;


string connectionString = "Server=tfnsdotde0401b; Database = Northwind; Trusted_Connection = True;";
SqlConnection myConnection = new SqlConnection(connectionString);


myConnection.Open();

SqlCommand sql = new SqlCommand();
SqlDataReader? myReader = null;
sql.CommandType = System.Data.CommandType.Text;
sql.Connection = myConnection;

sql.CommandText = @"insert into categories(CategoryName,Description) values('Test adonet','Description du test adonet')";

int nombreRows = sql.ExecuteNonQuery();
if(nombreRows == 0)
{
    Console.WriteLine("erreur");
}
else
{
    Console.WriteLine($"{nombreRows} ligne ajouté\n");
    sql.CommandText = "select * from categories";
    myReader = sql.ExecuteReader();
    while (myReader.Read())
    {
        var categoryID = (int)myReader[0];
        var categoryName = (string)myReader[1];
        var categoryDescription = (string)myReader[2];
        Console.WriteLine($"ID : {categoryID,-3} Name {categoryName,-15} Description : {categoryDescription,-30}");
    }
    myReader.Close();
}

sql.CommandText = "select count(*) from categories";
object result = sql.ExecuteScalar();
Console.WriteLine("\n"+result);

sql.CommandText = "delete from Categories where CategoryID > 8";
nombreRows = sql.ExecuteNonQuery();
Console.WriteLine($"\n{nombreRows} ligne supprimé");

myConnection.Close();